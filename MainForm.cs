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
using personal_library;

namespace PersonalLibrary
{
    public partial class MainForm : Form
    {
        private static readonly int AUTHOR_COLUMN_INDEX_ID = 0;
        private static readonly int AUTHOR_COLUMN_INDEX_FIRST_NAME = 1;
        private static readonly int AUTHOR_COLUMN_INDEX_LAST_NAME = 2;
        private static readonly int AUTHOR_COLUMN_INDEX_COMMENT = 3;

        private static readonly int CATEGORY_COLUMN_INDEX_ID = 0;
        private static readonly int CATEGORY_COLUMN_INDEX_NAME = 1;
        private static readonly int CATEGORY_COLUMN_INDEX_DESC = 2;

        private readonly Repository repository;
        private readonly LoginForm loginForm;
        public MainForm(LoginForm loginForm, User loggedInUser, Repository repository)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.repository = repository;
            SetTitle(loggedInUser);
            LoadData();
            
        }

        private void SetTitle(User loggedInUser) 
        {
            this.Text = "Personal library (" + loggedInUser.Type + ")";
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
            this.repository.CloseConnection();
            loginForm.Close();
        }
        private void LoadData()
        {
            Cursor oldCur = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Author> allAuthors = this.repository.GetAuthorDao().GetAllAuthors();
                List<Literature> literature = this.repository.GetLibraryDao().GetAllLiterature();
                List<Category> categories = this.repository.GetCategoryDao().GetAllCategories();
                PopulateAutorGridData(allAuthors);
                PopulateCategoryGridData(categories);
                Cursor.Current = oldCur;
            }
            catch (Exception ex)
            {
                Cursor.Current = oldCur;
                MessageBox.Show("Error loading data!:" + ex.Message);
            }
        }

        private void PopulateAutorGridData(List<Author> authors) 
        {
            DataTable authorsTable = CreateAuthorTable();
            foreach (Author author in authors)
            {
                 authorsTable.LoadDataRow(ToAuthorRow(author), true);
            }
        }

        private void PopulateCategoryGridData(List<Category> categories)
        {
            DataTable table = CreateCategotyTable();
            foreach (Category category in categories)
            {
                table.LoadDataRow(ToCategoryRow(category), true);
            }
        }

        private DataTable CreateAuthorTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Id", Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("First Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Last Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Comment", Type.GetType("System.String")));

            authorsGridView.DataSource = table;
            authorsGridView.Columns[AUTHOR_COLUMN_INDEX_ID].Width = 50;
            authorsGridView.Columns[AUTHOR_COLUMN_INDEX_FIRST_NAME].Width = 130;
            authorsGridView.Columns[AUTHOR_COLUMN_INDEX_LAST_NAME].Width = 130;
            authorsGridView.Columns[AUTHOR_COLUMN_INDEX_COMMENT].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        private DataTable CreateCategotyTable()
        {
            DataTable table = new DataTable();
            table.Columns.Add(new DataColumn("Id", Type.GetType("System.Int32")));
            table.Columns.Add(new DataColumn("Name", Type.GetType("System.String")));
            table.Columns.Add(new DataColumn("Description", Type.GetType("System.String")));

            cateroriesGridView.DataSource = table;
            cateroriesGridView.Columns[CATEGORY_COLUMN_INDEX_ID].Width = 50;
            cateroriesGridView.Columns[CATEGORY_COLUMN_INDEX_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cateroriesGridView.Columns[CATEGORY_COLUMN_INDEX_DESC].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        private object[] ToAuthorRow(Author author)
        {
            object[] values = new object[4];
            values[AUTHOR_COLUMN_INDEX_ID] = author.AuthorId;
            values[AUTHOR_COLUMN_INDEX_FIRST_NAME] = author.FirstName;
            values[AUTHOR_COLUMN_INDEX_LAST_NAME] = author.LastName;
            values[AUTHOR_COLUMN_INDEX_COMMENT] = author.Comment;
            return values;
        }

        private object[] ToCategoryRow(Category category)
        {
            object[] values = new object[3];
            values[CATEGORY_COLUMN_INDEX_ID]= category.CategoryId;
            values[CATEGORY_COLUMN_INDEX_NAME] = category.Name;
            values[CATEGORY_COLUMN_INDEX_DESC] = category.Description;
            return values;
        }

        private void AddNewAuthorButton_Click(object sender, EventArgs e)
        {
            AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(this);
            addEditAuthorForm.ShowDialog();
        }

        private void AddNewAuthor() 
        {
        }
    }

}
