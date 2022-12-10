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
    internal class AuthorDao:GenericDao<Author>
    {
        public AuthorDao(SqlConnection sqlConnection):base(sqlConnection)
        {
        }
        public List<Author> GetAllAuthors()
        {
            return ExecuteQuery("select * from author");
        }

        protected override Author LoadItem(SqlDataReader reader)
        {
            return new Author
            {
                AuthorId = reader.GetInt32(reader.GetOrdinal("author_id")),
                FirstName = reader.GetString(reader.GetOrdinal("first_name")),
                LastName = reader.GetString(reader.GetOrdinal("last_name")),
                BirthDate = reader.GetDateTime(reader.GetOrdinal("birth_date")),
                Comment = reader.GetString(reader.GetOrdinal("comment"))
            };
        }
    }

}
