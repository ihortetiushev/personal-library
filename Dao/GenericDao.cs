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
        protected virtual void PostProcessLoaded(T item) 
        {
            //do nothing by default
        }
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
            foreach (T item in items) 
            {
                PostProcessLoaded(item);
            }
            return items;
        }

        public void ExecuteNonQuery(string query)
        {
            SqlCommand command = new SqlCommand(query, sqlConnection);
            command.ExecuteNonQuery();
        }

        public int GetCount(string query)
        {
            int result = 0;
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataReader reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    result = reader.GetInt32(0);
                }
            }
            reader.Close();
            return result;
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
            PostProcessLoaded(found);
            return found;
        }
    }
}
