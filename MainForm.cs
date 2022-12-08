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
        private static readonly int COLUMN_INDEX_ID = 0;
        private static readonly int COLUMN_INDEX_FIRST_NAME = 1;
        private static readonly int COLUMN_INDEX_LAST_NAME = 2;
        private static readonly int COLUMN_INDEX_BIRTH_DATE = 3;
        private static readonly int COLUMN_INDEX_COMMENT = 4;
            
        private static readonly string CONNECTION_STRING = "data source=LAPTOP-EENRFF17\\SQLEXPRESS;initial catalog = course_project; User ID=lib_db_user;Password=123456;";
        private SqlConnection dbConnection;
        private LoginForm loginForm;
        private LibraryDao libraryDao;
        private AuthorDao authorDao;
        public MainForm(LoginForm loginForm, User loggedInUser)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.dbConnection = new SqlConnection(CONNECTION_STRING);
            this.libraryDao = new LibraryDao(dbConnection);
            this.authorDao = new AuthorDao(dbConnection);
            setTitle(loggedInUser);
            LoadData();
            
        }

        private void setTitle(User loggedInUser) 
        {
            this.Text = "Personal library (" + loggedInUser.userType + ")";
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
                populateAutorGridData(allAuthors);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open db connection ! " + ex.Message);
            }
        }

        private void populateAutorGridData(List<Author> authors) 
        {
            DataTable authorsTable = createTable(authorsGridView);
            foreach (Author author in authors)
            {
                 authorsTable.LoadDataRow(toAuthorRow(author), true);
            }
        }

        private DataTable createTable(System.Windows.Forms.DataGridView dataGrid)
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Id", Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("First Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Last Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Birth Date", Type.GetType("System.DateTime")));
            table.Columns.Add(new DataColumn("Comment", Type.GetType("System.String")));

            dataGrid.DataSource = table;
            dataGrid.Columns[COLUMN_INDEX_ID].Width = 50;
            dataGrid.Columns[COLUMN_INDEX_FIRST_NAME].Width = 130;
            dataGrid.Columns[COLUMN_INDEX_LAST_NAME].Width = 130;
            dataGrid.Columns[COLUMN_INDEX_BIRTH_DATE].Width = 70;
            dataGrid.Columns[COLUMN_INDEX_COMMENT].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        private object[] toAuthorRow(Author author)
        {
            object[] values = new object[5];
            values[COLUMN_INDEX_ID] = author.authorId;
            values[COLUMN_INDEX_FIRST_NAME] = author.firstName;
            values[COLUMN_INDEX_LAST_NAME] = author.lastName;
            values[COLUMN_INDEX_BIRTH_DATE] = author.birthDate;
            values[COLUMN_INDEX_COMMENT] = author.comment;
            return values;
        }
    }
}
