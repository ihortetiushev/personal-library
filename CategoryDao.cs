using System.Collections.Generic;
using System.Data.SqlClient;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    internal class CategoryDao:GenericDao<Category>
    {
        public CategoryDao(SqlConnection sqlConnection):base(sqlConnection)
        {
            
        }

        public List<Category> GetAllCategories()
        {
            return ExecuteQuery("select * from category");
        }

        protected override Category LoadItem(SqlDataReader reader)
        {
            return new Category
            {
                CategoryId = reader.GetInt32(reader.GetOrdinal("category_id")),
                Name = reader.GetString(reader.GetOrdinal("name")),
                Description = reader.GetString(reader.GetOrdinal("description"))
            };
        }
    }

}
