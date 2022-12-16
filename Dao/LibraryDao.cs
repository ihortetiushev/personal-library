using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
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
        public void CreateLiterature(Literature literature)
        {
            try
            {
                if (literature.LiteratureId > 0)
                {
                    throw new ArgumentException("CategoryId must be not positive");
                }
                //TODO - implement
                var sql = @"INSERT into category 
                            (name, description) OUTPUT Inserted.category_id
                            VALUES(@Name, @Description)";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                    //cmd.Parameters.AddWithValue("@Name", category.Name);
                    //cmd.Parameters.AddWithValue("@Description", category.Description);
                    int insertedID = Convert.ToInt32(cmd.ExecuteScalar());
                    literature.LiteratureId = insertedID;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Data is not saved " + e.Message, "Error!",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Error);
            }
        }

        public void UpdateLiterature(Literature literature)
        {
            try
            {
                if (literature.LiteratureId <= 0)
                {
                    throw new ArgumentException("LiteratureId must be positive");
                }
                //TODO - implement
                var sql = @"update category set 
                            name = @Name,
                            description = @Description
                            where category_id = @Id";
                using (var cmd = new SqlCommand(sql, sqlConnection))
                {
                   // cmd.Parameters.AddWithValue("@Name", category.Name);
                   // cmd.Parameters.AddWithValue("@Description", category.Description);
                   // cmd.Parameters.AddWithValue("@Id", category.CategoryId);
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

        public Literature GetById(int literatureId)
        {
            Literature literature = base.GetById("select * from literature where author_id = @Id", literatureId);
            //TODO - populate related objects
            return literature;
        }
        public void DeleteLiterature(int literatureId)
        {
            //TODO - implement
            //base.ExecuteNonQuery("delete from category where category_id = " + literatureId);
        }
    }

}
