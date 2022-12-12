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
using PersonalLibrary.View;

namespace PersonalLibrary
{
    public partial class MainForm : Form
    {
        private static readonly int ID_COLUMN_INDEX = 0;
        private static readonly int AUTHOR_COLUMN_INDEX_FIRST_NAME = 1;
        private static readonly int AUTHOR_COLUMN_INDEX_LAST_NAME = 2;
        private static readonly int AUTHOR_COLUMN_INDEX_COMMENT = 3;

        private static readonly int CATEGORY_COLUMN_INDEX_NAME = 1;
        private static readonly int CATEGORY_COLUMN_INDEX_DESC = 2;

        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly LoginForm loginForm;
        private DataTable authorsTable;
        public MainForm(LoginForm loginForm, UIState uiState, Repository repository)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.repository = repository;
            this.uiState = uiState;
            this.readOnly = uiState.LoggedInUser.Type == User.UserType.Reader;
            InitializeState(uiState);
            LoadData();
            
        }

        private void InitializeState(UIState uiState) 
        {
            this.Text = "Personal library (" + uiState.LoggedInUser.Type + ")";
            this.addNewAuthorButton.Enabled = !readOnly;
            this.addNewCaterogyButton.Enabled = !readOnly;
            this.addNewAutorToolStripMenuItem.Enabled = !readOnly;
            //this.editAuthorToolStripMenuItem.Enabled = !readOnly;
            this.deleteAuthorToolStripMenuItem.Enabled = !readOnly;
            this.addNewCategoryToolStripMenuItem.Enabled = !readOnly;
            //this.editViewCategoryToolStripMenuItem.Enabled = !readOnly;
            this.deleteCategotyToolStripMenuItem.Enabled = !readOnly;
            SetActiveTabState();
        }
       

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            if (!DoExit()) 
            {
                e.Cancel = true;
            }
        }

        private bool DoExit() 
        {
            var result = MessageBox.Show("Do you want to exit?", "Confirm exit",
                             MessageBoxButtons.YesNo,
                             MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                 return false;
            }
            this.repository.CloseConnection();
            loginForm.Close();
            return true;
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
            this.authorsTable = CreateAuthorTable();
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
            authorsGridView.Columns[ID_COLUMN_INDEX].Width = 50;
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
            cateroriesGridView.Columns[ID_COLUMN_INDEX].Width = 50;
            cateroriesGridView.Columns[CATEGORY_COLUMN_INDEX_NAME].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            cateroriesGridView.Columns[CATEGORY_COLUMN_INDEX_DESC].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            return table;
        }

        private object[] ToAuthorRow(Author author)
        {
            object[] values = new object[4];
            values[ID_COLUMN_INDEX] = author.AuthorId;
            values[AUTHOR_COLUMN_INDEX_FIRST_NAME] = author.FirstName;
            values[AUTHOR_COLUMN_INDEX_LAST_NAME] = author.LastName;
            values[AUTHOR_COLUMN_INDEX_COMMENT] = author.Comment;
            return values;
        }

        private object[] ToCategoryRow(Category category)
        {
            object[] values = new object[3];
            values[ID_COLUMN_INDEX] = category.CategoryId;
            values[CATEGORY_COLUMN_INDEX_NAME] = category.Name;
            values[CATEGORY_COLUMN_INDEX_DESC] = category.Description;
            return values;
        }

        private void AddNewAuthorButton_Click(object sender, EventArgs e)
        {
            AddNewAuthor();
        }

        private void AddNewAuthor() 
        {
            uiState.LastModified = null;
            AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(this, repository, uiState);
            addEditAuthorForm.ShowDialog();
            RefreshGridData();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoExit();
        }

        private void AddNewCaterogyButton_Click(object sender, EventArgs e)
        {

        }

        private void RefreshGridData()
        {
            if (uiState.LastOperation == Operation.CANCEL)
            {
                return;
            }
            int? id= uiState.LastModifiedId;
            Author autor = (Author)uiState.LastModified;
            //Employee employee = repository.get.repo.getById(id);
            DataGridView activeGrid = this.authorsGridView;
            if (uiState.LastOperation == Operation.CREATE)
            {
                AddCreatedRecordToTable(autor);
                return;
            }
            if (activeGrid.RowCount > 0)
            {
                for (int i = 0; i < activeGrid.RowCount; i++)
                {
                    object idObj = activeGrid.Rows[i].Cells[ID_COLUMN_INDEX].Value;
                    if (id.Equals(idObj))
                    {
                        if (uiState.LastOperation == Operation.UPDATE)
                        {
                            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_FIRST_NAME].Value = autor.FirstName;
                            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_LAST_NAME].Value = autor.LastName;
                            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_COMMENT].Value = autor.Comment;
                        }
                        else if (uiState.LastOperation == Operation.DELETE)
                        {
                            activeGrid.Rows.RemoveAt(activeGrid.Rows[i].Index);
                        }
                        break;
                    }
                }
            }
            //dataGridActive.Columns[ID_INDEX].Visible = false;
            //dataGridDeleted.Columns[ID_INDEX].Visible = false;
        }

        private void AddCreatedRecordToTable(Author author)
        {
            object[] rowData = ToAuthorRow(author);
            /*if (thistableActive == nullptr)
            {
                this.tableActive = createTable(dataGridActive);
            }*/
            this.authorsTable.LoadDataRow(rowData, true);
        }

        private void AddNewAutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewAuthor();
        }

        private void EditAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditAuthor();
        }

        private void DeleteAuthorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            //TabControl
            /*TabControl tab = (TabControl)sender;
            if (tab.SelectedTab == this.tabAuthors) 
            {
            }*/
            SetActiveTabState();
        }
        private void SetActiveTabState() 
        {
            SetAutorsItemsState();
            SetCateroriesItemsState();
        }
        private void SetAutorsItemsState() 
        {
            if (this.tabControl.SelectedTab == this.authorsTab)
            {
                this.editAuthorToolStripMenuItem.Enabled = true;
                this.deleteAuthorToolStripMenuItem.Enabled = !readOnly;
            }
            else
            {
                this.editAuthorToolStripMenuItem.Enabled = false;
                this.deleteAuthorToolStripMenuItem.Enabled = false;
            }
        }
        private void SetCateroriesItemsState()
        {
            if (this.tabControl.SelectedTab == this.categoriesTab)
            {
                this.editViewCategoryToolStripMenuItem.Enabled = !readOnly;
                this.deleteCategotyToolStripMenuItem.Enabled = !readOnly;
            }
            else
            {
                this.editViewCategoryToolStripMenuItem.Enabled = false;
                this.deleteCategotyToolStripMenuItem.Enabled = false;
            }
        }

        private void AddNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EditViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditAuthor();
        }

        private void DeleteCategotyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void ViewEditAuthor()
        {
            DataGridViewSelectedRowCollection selected = this.authorsGridView.SelectedRows;
            if (selected.Count == 0)
            {
                MessageBox.Show("No data selected for editing", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Object objId = this.authorsGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            Author toEdit = this.repository.GetAuthorDao().GetById((int)objId);
            uiState.LastModified = toEdit;
            AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(this, repository, uiState);
            addEditAuthorForm.ShowDialog();
            RefreshGridData();
        }
    }



}
