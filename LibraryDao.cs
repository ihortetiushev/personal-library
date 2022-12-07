using System.Collections.Generic;
using System.Data.SqlClient;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    internal class LibraryDao
    {
        private SqlConnection sqlConnection;
        public LibraryDao(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        public List<Literature> GetAllLiterature()
        {
            List<Literature> literatureList = new List<Literature>();
            SqlCommand command = new SqlCommand("select * from literature", sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Literature item = new Literature();
                    item.literatureId = reader.GetInt32(reader.GetOrdinal("literature_id"));
                    item.title = reader.GetString(reader.GetOrdinal("title"));

                    literatureList.Add(item);
                }
            }
            reader.Close();
            return literatureList;
        }
    }

}
