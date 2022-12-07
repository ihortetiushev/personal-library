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
    internal class AuthorDao
    {
        private SqlConnection sqlConnection;
        public AuthorDao(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        public List<Author> GetAllAuthors()
        {
            List<Author> authors = new List<Author>();
            SqlCommand command = new SqlCommand("select * from author", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Author item = new Author();
                    item.authorId = reader.GetInt32(reader.GetOrdinal("author_id"));
                    item.firstName = reader.GetString(reader.GetOrdinal("first_name"));
                    item.lastName = reader.GetString(reader.GetOrdinal("last_name"));
                    item.birthDate = reader.GetDateTime(reader.GetOrdinal("birth_date"));
                    item.comment = reader.GetString(reader.GetOrdinal("comment"));

                    authors.Add(item);
                }
            }
            reader.Close();
            return authors;
        }
    }

}
