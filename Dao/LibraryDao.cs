using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    public class LibraryDao:GenericDao<Literature>
    {
        private readonly AuthorDao authorDao;
        private readonly CategoryDao categoryDao;

        public LibraryDao(SqlConnection sqlConnection, AuthorDao authorDao, CategoryDao categoryDao) : base(sqlConnection)
        {
            this.authorDao = authorDao;
            this.categoryDao = categoryDao;
        }
        public List<Literature> GetAllLiterature()
        {
            return base.ExecuteQuery("select * from literature");
        }

        protected override void PostProcessLoaded(Literature item)
        {
            item.CategoryName = categoryDao.GetById(item.CategoryId).Name;
            item.Authors = LoadAuthors(item);
            LoadOrigin(item);
        }

        private void LoadOrigin(Literature item)
        {
            if (item.OriginId != null)
            {
                var query = "select * from origin where origin_id = " + item.OriginId;
                SqlCommand command = new SqlCommand(query, sqlConnection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        int dateIdx = reader.GetOrdinal("date");
                        int commentIdx = reader.GetOrdinal("comment");
                        item.OriginDate = reader.IsDBNull(dateIdx) ? (DateTime?)null : reader.GetDateTime(dateIdx);
                        item.OriginComment = reader.IsDBNull(commentIdx) ? null : reader.GetString(commentIdx);
                    }
                }
                reader.Close();
            }
        }

        private List<Author> LoadAuthors(Literature item)
        {
            var query = "select author_id from literature_author where literature_id = " + item.LiteratureId;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader authorsReader = command.ExecuteReader();
            List<int> authorIds = new List<int>();
            if (authorsReader.HasRows)
            {
                while (authorsReader.Read())
                {
                    authorIds.Add(authorsReader.GetInt32(authorsReader.GetOrdinal("author_id")));
                }
            }
            authorsReader.Close();
            List<Author> authors = new List<Author>();
            foreach (int authorId in authorIds)
            {
                authors.Add(authorDao.GetById(authorId));
            }

            return authors;
        }

        protected override Literature LoadItem(SqlDataReader reader)
        {
            int publishDateIdx = reader.GetOrdinal("publish_date");
            int originIdx = reader.GetOrdinal("origin_id");
            int commentIdx = reader.GetOrdinal("comment");
            return new Literature
            {
                LiteratureId = reader.GetInt32(reader.GetOrdinal("literature_id")),
                CategoryId = reader.GetInt32(reader.GetOrdinal("category_id")),
                Title = reader.GetString(reader.GetOrdinal("title")),
                ISBN = reader.GetString(reader.GetOrdinal("isbn")),
                Publisher = reader.GetString(reader.GetOrdinal("publisher")),
                PublishDate = reader.IsDBNull(publishDateIdx) ? (DateTime?)null : reader.GetDateTime(publishDateIdx),
                OriginId = reader.IsDBNull(originIdx) ? (int?)null: reader.GetInt32(originIdx),
                IsAvailable = reader.GetBoolean(reader.GetOrdinal("is_available")),
                Comment = reader.IsDBNull(commentIdx) ? null : reader.GetString(commentIdx)
            };
        }
        public bool CreateLiterature(Literature literature)
        {
            SqlTransaction transaction = null;
            try
            {
                if (literature.LiteratureId > 0)
                {
                    throw new ArgumentException("CategoryId must be not positive");
                }
                transaction = sqlConnection.BeginTransaction();

                InsertOrigin(literature, transaction);
                InsertLiterature(literature, transaction);
                InsertAuthors(literature, transaction);

                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return false;
            }
        }

        private void InsertOrigin(Literature literature, SqlTransaction transaction)
        {
            if (literature.OriginDate == null && 
                (literature.OriginComment == null || literature.OriginComment.Trim().Length ==0)) 
            {
                literature.OriginId = null;
                return;
            }
            var sql = @"INSERT into origin 
                            (date, 
                            comment) OUTPUT Inserted.origin_id
                            VALUES
                            (@Date,
                            @Comment)";
            using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
            {
                cmd.Parameters.AddWithValue("@Date", SetNullableValue(literature.OriginDate));
                cmd.Parameters.AddWithValue("@Comment", SetNullableValue(literature.OriginComment));
                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                literature.OriginId = insertedID;
            }
        }
        private void InsertLiterature(Literature literature, SqlTransaction transaction)
        {
            var sql = @"INSERT into literature 
                            (category_id, 
                            title,
                            isbn,
                            publisher,
                            publish_date,
                            origin_id,
                            is_available,
                            comment) OUTPUT Inserted.literature_id
                            VALUES
                            (@CategoryId,
                            @Title,
                            @ISBN,
                            @Publisher,
                            @PublishDate,
                            @OriginId,
                            @IsAvailable,
                            @Comment)";
            using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
            {
                cmd.Parameters.AddWithValue("@CategoryId", literature.CategoryId);
                cmd.Parameters.AddWithValue("@Title", literature.Title);
                cmd.Parameters.AddWithValue("@ISBN", SetNullableValue(literature.ISBN));
                cmd.Parameters.AddWithValue("@Publisher", SetNullableValue(literature.Publisher));
                cmd.Parameters.AddWithValue("@PublishDate", SetNullableValue(literature.PublishDate));
                cmd.Parameters.AddWithValue("@OriginId", SetNullableValue(literature.OriginId));
                cmd.Parameters.AddWithValue("@IsAvailable", literature.IsAvailable);
                cmd.Parameters.AddWithValue("@Comment", SetNullableValue(literature.Comment));
                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                literature.LiteratureId = insertedID;
            }
        }

        private void UpdateLiterature(Literature literature, SqlTransaction transaction)
        {
            var sql = @"update literature set
                               category_id = @CategoryId,
                               title = @Title,
                               isbn =  @ISBN,
                               publisher = @Publisher,
                               publish_date = @PublishDate,
                               origin_id = @OriginId,
                               is_available = @IsAvailable,
                               comment = @Comment      
                               where literature_id = @Id";
            using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
            {
                cmd.Parameters.AddWithValue("@CategoryId", literature.CategoryId);
                cmd.Parameters.AddWithValue("@Title", literature.Title);
                cmd.Parameters.AddWithValue("@ISBN", SetNullableValue(literature.ISBN));
                cmd.Parameters.AddWithValue("@Publisher", SetNullableValue(literature.Publisher));
                cmd.Parameters.AddWithValue("@PublishDate", SetNullableValue(literature.PublishDate));
                cmd.Parameters.AddWithValue("@OriginId", SetNullableValue(literature.OriginId));
                cmd.Parameters.AddWithValue("@IsAvailable", literature.IsAvailable);
                cmd.Parameters.AddWithValue("@Comment", SetNullableValue(literature.Comment));
                cmd.Parameters.AddWithValue("@Id", literature.LiteratureId);
                cmd.ExecuteScalar();
            }
        }

        private Object SetNullableValue(Object value) 
        {
            if (value == null) 
            {
                return DBNull.Value;
            }
            return value;
        }

        //for the simplicity delete origin for the literature in order to handle update the same way as create
        private void DeleteOriginIfPresent(int? originId, SqlTransaction transaction)
        {
            if (originId == null) 
            {
                return;
            }
            string sql = "delete from origin where origin_id = @OriginId";
            using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
            {
                cmd.Parameters.AddWithValue("@OriginId", originId);
                cmd.ExecuteScalar();
            }
        }

        //for the simplicity delete all authors for the literature and add them from scratch
        private void DeleteAllAuthorsForLiterature(Literature literature, SqlTransaction transaction) 
        {
            string sql = "delete from literature_author where literature_id = @LiteratureId";
            using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
            {
               cmd.Parameters.AddWithValue("@LiteratureId", literature.LiteratureId);
               cmd.ExecuteScalar();
            }
        }

        private void InsertAuthors(Literature literature, SqlTransaction transaction)
        {
            string sql = @"INSERT into literature_author (literature_id, author_id)
                            VALUES (@LiteratureId, @AuthorId)";
            foreach (Author author in literature.Authors)
            {
                using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("@LiteratureId", literature.LiteratureId);
                    cmd.Parameters.AddWithValue("@AuthorId", author.AuthorId);
                    cmd.ExecuteScalar();
                }
            }
        }

        public bool UpdateLiterature(Literature literature)
        {
            SqlTransaction transaction = null;
            try
            {
                if (literature.LiteratureId < 0)
                {
                    throw new ArgumentException("CategoryId must be positive");
                }
                transaction = sqlConnection.BeginTransaction();
                int? oldOrigin = literature.OriginId;
                InsertOrigin(literature, transaction);
                UpdateLiterature(literature, transaction);
                DeleteOriginIfPresent(oldOrigin, transaction);
                DeleteAllAuthorsForLiterature(literature, transaction);
                InsertAuthors(literature, transaction);

                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return false;
            }
        }

        public Literature GetById(int literatureId)
        {
            return base.GetById("select * from literature where literature_id = @Id", literatureId);
        }
        public bool DeleteLiterature(int literatureId)
        {
            Literature literature = this.GetById(literatureId);
            int? originId = literature.OriginId;
            SqlTransaction transaction = null;
            try
            {

                transaction = sqlConnection.BeginTransaction();
                string sql = "delete from literature_author where literature_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("@Id", literatureId);
                    cmd.ExecuteScalar();
                }
                sql = "delete from literature where literature_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
                {
                    cmd.Parameters.AddWithValue("@Id", literatureId);
                    cmd.ExecuteScalar();
                }
                if (originId != null) 
                {
                   sql = "delete from origin where origin_id = @Id";   
                    using (var cmd = new SqlCommand(sql, sqlConnection, transaction))
                    {
                     cmd.Parameters.AddWithValue("@Id", originId);
                     cmd.ExecuteScalar();
                    }
                }
                transaction.Commit();
                return true;
            }
            catch (Exception e)
            {
                transaction.Rollback();
                MessageBox.Show("Data is not Deleted" + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
                return false;
            }
        }

        public List<Literature> DoSearch(SearchCriteria searchCriteria)
        {
            int available = searchCriteria.IsAvailable ? 1 : 0;
            string sql = "select * from literature where is_available = " + available;
            if (searchCriteria.Title.Length !=0) 
            {
                sql = sql + " and title like '%" + searchCriteria.Title + "%'";
            }
            if (IsAuthorSearchIncluded(searchCriteria)) 
            {
                sql = sql + " and literature_id in (" + AddAuthorSearchCriteria(searchCriteria) + ")";
            }
            return base.ExecuteQuery(sql);
        }
        private bool IsAuthorSearchIncluded(SearchCriteria searchCriteria) 
        {
            return searchCriteria.AuthorFirstName.Length != 0 || searchCriteria.AuthorLastName.Length != 0;
        }

        private string AddAuthorSearchCriteria(SearchCriteria searchCriteria) 
        {
            string authorSql = "select author_id from author where 1=1";
            if (searchCriteria.AuthorFirstName.Length != 0)
            {
                authorSql = authorSql + " and first_name like '%" + searchCriteria.AuthorFirstName + "%'";
            }
            if (searchCriteria.AuthorLastName.Length != 0)
            {
                authorSql = authorSql + " and last_name like '%" + searchCriteria.AuthorLastName + "%'";
            }
            string authorLiteratureSql = "select literature_id from literature_author where author_id in (" + authorSql + ")";
            return authorLiteratureSql;
        }
    }
}
