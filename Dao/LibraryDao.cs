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
            List<Author> authors =new List<Author>();
            foreach (int authorId in authorIds) 
            {
                authors.Add(authorDao.GetById(authorId));
            }
            item.Authors = authors;

        }
        protected override Literature LoadItem(SqlDataReader reader)
        {
            return new Literature
            {
                LiteratureId = reader.GetInt32(reader.GetOrdinal("literature_id")),
                CategoryId = reader.GetInt32(reader.GetOrdinal("category_id")),
                Title = reader.GetString(reader.GetOrdinal("title")),
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

                //TODO - implement
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
                cmd.Parameters.AddWithValue("@PublishDate", SetNullableValue(null)/*literature.PublishDate*/);
                //TODO
                cmd.Parameters.AddWithValue("@OriginId", SetNullableValue(null));
                cmd.Parameters.AddWithValue("@IsAvailable", SetNullableValue(literature.IsAvailable));
                cmd.Parameters.AddWithValue("@Comment", SetNullableValue(literature.Comment));
                int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                literature.LiteratureId = insertedID;
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

        public void UpdateLiterature(Literature literature)
        {
            try
            {
                if (literature.LiteratureId <= 0)
                {
                    throw new ArgumentException("LiteratureId must be positive");
                }
                //TODO - implement
                var sql = @"update category set 
                            name = @Name,
                            description = @Description
                            where category_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                   // cmd.Parameters.AddWithValue("@Name", category.Name);
                   // cmd.Parameters.AddWithValue("@Description", category.Description);
                   // cmd.Parameters.AddWithValue("@Id", category.CategoryId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        public Literature GetById(int literatureId)
        {
            Literature literature = base.GetById("select * from literature where author_id = @Id", literatureId);
            //TODO - populate related objects
            return literature;
        }
        public void DeleteLiterature(int literatureId)
        {
            //TODO - implement
            //base.ExecuteNonQuery("delete from category where category_id = " + literatureId);
        }
    }

}
