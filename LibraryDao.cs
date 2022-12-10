using System.Collections.Generic;
using System.Data.SqlClient;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    public class LibraryDao:GenericDao<Literature>
    {
        public LibraryDao(SqlConnection sqlConnection):base(sqlConnection)
        {
        }
        public List<Literature> GetAllLiterature()
        {
            return base.ExecuteQuery("select * from literature");
        }

        protected override Literature LoadItem(SqlDataReader reader)
        {
            return new Literature
            {
                LiteratureId = reader.GetInt32(reader.GetOrdinal("literature_id")),
                Title = reader.GetString(reader.GetOrdinal("title"))
            };
        }
    }

}
