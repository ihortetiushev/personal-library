using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PersonalLibrary.Dao;
using PersonalLibrary.Models;

namespace PersonalLibrary
{
    public partial class MainForm : Form
    {
        private static readonly string CONNECTION_STRING = "data source=LAPTOP-EENRFF17\\SQLEXPRESS;initial catalog = course_project; User ID=lib_db_user;Password=123456;";
        private SqlConnection dbConnection;
        private LoginForm loginForm;
        private LibraryDao libraryDao;
        private AuthorDao authorDao;
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.dbConnection = new SqlConnection(CONNECTION_STRING);
            this.libraryDao = new LibraryDao(dbConnection);
            this.authorDao = new AuthorDao(dbConnection);
            LoadData();
        }

       

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Do you want to exit?", "Confirm exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            dbConnection.Close();
            loginForm.Close();
        }
        private void LoadData()
        {
            try
            {
                dbConnection.Open();
                List<Author> allAuthors = authorDao.GetAllAuthors();
                List<Literature> literature = libraryDao.GetAllLiterature();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open db connection ! " + ex.Message);
            }
        }
    }
}
