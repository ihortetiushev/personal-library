using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    public class AuthorDao : GenericDao<Author>
    {
        public AuthorDao(SqlConnection sqlConnection):base(sqlConnection)
        {
        }
        public List<Author> GetAllAuthors()
        {
            return ExecuteQuery("select * from author");
        }
        public void CreateAuthor(Author author)
        {
            try
            {
                if (author.AuthorId > 0)
                {
                    throw new ArgumentException("AuthorId must be not positive");
                }
                var sql = @"INSERT into author 
                            (first_name, last_name, comment) OUTPUT Inserted.author_id
                            VALUES(@FirstName, @LastName, @Comment)";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", author.LastName);
                    cmd.Parameters.AddWithValue("@Comment", author.Comment);
                    int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                    author.AuthorId = insertedID;
                }
            } catch (Exception e)
            {
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }
        public void UpdateAuthor(Author author)
        {
            try
            {
                if (author.AuthorId <= 0)
                {
                    throw new ArgumentException("AuthorId must be positive");
                }
                var sql = @"update author set 
                            first_name = @FirstName,
                            last_name = @LastName,
                            comment = @Comment where author_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", author.LastName);
                    cmd.Parameters.AddWithValue("@Comment", author.Comment);
                    cmd.Parameters.AddWithValue("@Id", author.AuthorId);
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

        protected override Author LoadItem(SqlDataReader reader)
        {
            return new Author
            {
                AuthorId = reader.GetInt32(reader.GetOrdinal("author_id")),
                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                Comment = reader.GetString(reader.GetOrdinal("comment"))
            };
        }

        public Author GetById(int authorId) 
        {
            return base.GetById("select * from author where author_id = @Id", authorId);
        }
    }

}
