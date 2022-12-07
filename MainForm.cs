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
            dataGrid.Columns[0].Width = 50;
            dataGrid.Columns[1].Width = 150;
            dataGrid.Columns[2].Width = 150;
            dataGrid.Columns[3].Width = 70;
            dataGrid.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        private object[] toAuthorRow(Author author)
        {
            object[] values = new object[5];
            values[0] = author.authorId;
            values[1] = author.firstName;
            values[2] = author.lastName;
            values[3] = author.birthDate;
            values[4] = author.comment;
            return values;
        }
    }
}
