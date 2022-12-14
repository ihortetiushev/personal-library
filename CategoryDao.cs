using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    public class CategoryDao:GenericDao<Category>
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

        public void CreateCategory(Category category)
        {
            try
            {
                if (category.CategoryId > 0)
                {
                    throw new ArgumentException("CategoryId must be not positive");
                }
                var sql = @"INSERT into category 
                            (name, description) OUTPUT Inserted.category_id
                            VALUES(@Name, @Description)";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", category.Name);
                    cmd.Parameters.AddWithValue("@Description", category.Description);
                    int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                    category.CategoryId = insertedID;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        public void UpdateCategory(Category category)
        {
            try
            {
                if (category.CategoryId <= 0)
                {
                    throw new ArgumentException("CategoryId must be positive");
                }
                var sql = @"update category set 
                            name = @Name,
                            description = @Description
                            where category_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@Name", category.Name);
                    cmd.Parameters.AddWithValue("@Description", category.Description);
                    cmd.Parameters.AddWithValue("@Id", category.CategoryId);
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
        public Category GetById(int categoryId)
        {
            return base.GetById("select * from category where category_id = @Id", categoryId);
        }
    }

}
