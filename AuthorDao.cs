using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public Author CreateAuthor(Author author)
        {
            if (author.AuthorId > 0) 
            {
                throw new ArgumentException("AuthorId must be not positive");
            }
            var sql = "INSERT author (first_name, last_name, comment) VALUES(@FirstName, @LastName, @Comment)";
            using (var cmd = new SqlCommand(sql, sqlConnection))
            {
                cmd.Parameters.AddWithValue("@FirstName", author.FirstName);
                cmd.Parameters.AddWithValue("@LastName", author.LastName);
                cmd.Parameters.AddWithValue("@Comment", author.Comment);
                int modified = (int)cmd.ExecuteScalar();
                author.AuthorId = modified;
            }
            return author;
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
    }

}
