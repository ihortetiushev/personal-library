using System.Collections.Generic;
using System.Data.SqlClient;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    internal abstract class GenericDao<T>
    {
        private readonly SqlConnection sqlConnection;
        public GenericDao(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
        protected abstract T LoadItem(SqlDataReader reader);
        public List<T> ExecuteQuery(string query)
        {
            List<T> items = new List<T>();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    items.Add(LoadItem(reader));
                }
            }
            reader.Close();
            return items;
        }
    }
}
