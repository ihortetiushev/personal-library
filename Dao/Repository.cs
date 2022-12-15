using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using PersonalLibrary.Models;


namespace PersonalLibrary.Dao
{
    public class Repository
    {
        private static readonly string CONNECTION_STRING = "data source=LAPTOP-EENRFF17\\SQLEXPRESS;initial catalog = course_project; User ID=lib_db_user;Password=123456;";
        private SqlConnection sqlConnection;
        private AuthorDao authorDao;
        private CategoryDao categoryDao;
        private LibraryDao libraryDao;
        public Repository() 
        {
            Init();
        }
        private void Init()
        {
            this.sqlConnection = new SqlConnection(CONNECTION_STRING);
            this.libraryDao = new LibraryDao(sqlConnection);
            this.authorDao = new AuthorDao(sqlConnection);
            this.categoryDao = new CategoryDao(sqlConnection);
        }
        public bool OpenConnection() 
        {
            try
            {
                sqlConnection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the database can not contunue! " + ex.Message);
                return false;
            }
            return true;
        }
        public void CloseConnection() 
        {
            sqlConnection.Close();
        }
        public AuthorDao GetAuthorDao() 
        {
            return authorDao;
        }
        public CategoryDao GetCategoryDao()
        {
            return categoryDao;
        }
        public LibraryDao GetLibraryDao()
        {
            return libraryDao;
        }
    }
}
