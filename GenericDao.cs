using System.Collections.Generic;
using System.Data.SqlClient;


namespace PersonalLibrary.Dao
{
    public abstract class GenericDao<T>
    {
        protected readonly SqlConnection sqlConnection;
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

        public T GetById(string query, int id)
        {
            T found = default;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.Parameters.AddWithValue("@Id", id);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    found = LoadItem(reader);
                }
            }
            reader.Close();
            return found;
        }
    }
}
