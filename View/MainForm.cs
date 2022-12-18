using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using static PersonalLibrary.View.UIHelper;


namespace PersonalLibrary.View
{
    public partial class MainForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly LoginForm loginForm;
        private DataTable authorsTable;
        private DataTable categoryTable;
        private DataTable literatureTable;
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
            this.addNewCategoryButton.Enabled = !readOnly;
            this.addNewAutorToolStripMenuItem.Enabled = !readOnly;
            this.deleteAuthorToolStripMenuItem.Enabled = !readOnly;
            this.addNewCategoryToolStripMenuItem.Enabled = !readOnly;
            this.deleteCategotyToolStripMenuItem.Enabled = !readOnly;
            this.addLiteratureToolStripMenuItem.Enabled = !readOnly;
            this.deleteLiteratureToolStripMenuItem.Enabled = !readOnly;
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
                this.literatureTable = PopulateLiteratureGridData(literature, this.literatureGridView);
                this.authorsTable = PopulateAutorGridData(allAuthors, this.authorsGridView);
                this.categoryTable = PopulateCategoryGridData(categories,this.categoriesGridView);
                Cursor.Current = oldCur;
            }
            catch (Exception ex)
            {
                Cursor.Current = oldCur;
                MessageBox.Show("Error loading data!:" + ex.Message);
            }
        }

        private void AddNewAuthorButton_Click(object sender, EventArgs e)
        {
            AddNewAuthor();
        }

        private void AddNewAuthor() 
        {
            uiState.LastModified = null;
            AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(repository, uiState);
            addEditAuthorForm.ShowDialog();
            RefreshGridData(authorsGridView);
        }

        private void AddNewCategory()
        {
            uiState.LastModified = null;
            AddEditCategoryForm addEditCategoryForm = new AddEditCategoryForm(repository, uiState);
            addEditCategoryForm.ShowDialog();
            RefreshGridData(categoriesGridView);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoExit();
        }

        private void AddNewCategoryButton_Click(object sender, EventArgs e)
        {
            AddNewCategory();
        }
        
        private void updateGridDate(DataGridView activeGrid, int i, Object data) 
        {
            if (data.GetType() == typeof(Author)) 
            {
                updateGridDate(activeGrid, i, (Author)data);
            }
            if (data.GetType() == typeof(Category))
            {
                updateGridDate(activeGrid, i, (Category)data);
            }
        }

        private void updateGridDate(DataGridView activeGrid, int i, Author autor)
        {
            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_FIRST_NAME].Value = autor.FirstName;
            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_LAST_NAME].Value = autor.LastName;
            activeGrid.Rows[i].Cells[AUTHOR_COLUMN_INDEX_COMMENT].Value = autor.Comment;
        }

        private void updateGridDate(DataGridView activeGrid, int i, Category category)
        {
            activeGrid.Rows[i].Cells[CATEGORY_COLUMN_INDEX_NAME].Value = category.Name;
            activeGrid.Rows[i].Cells[CATEGORY_COLUMN_INDEX_DESC].Value = category.Description;
        }

        private void RefreshGridData(DataGridView dataGrid)
        {
            if (uiState.LastOperation == Operation.CANCEL)
            {
                return;
            }
            int? id= uiState.LastModifiedId;
            Object data = uiState.LastModified;
            if (uiState.LastOperation == Operation.CREATE)
            {
                AddCreatedRecordToTable(data);
                return;
            }
            if (dataGrid.RowCount > 0)
            {
                for (int i = 0; i < dataGrid.RowCount; i++)
                {
                    object idObj = dataGrid.Rows[i].Cells[ID_COLUMN_INDEX].Value;
                    if (id.Equals(idObj))
                    {
                        if (uiState.LastOperation == Operation.UPDATE)
                        {
                            updateGridDate(dataGrid, i, data);
                        }
                        else if (uiState.LastOperation == Operation.DELETE)
                        {
                            dataGrid.Rows.RemoveAt(dataGrid.Rows[i].Index);
                        }
                        break;
                    }
                }
            }

        }

        private void AddCreatedRecordToTable(Object data) 
        {
            if (data.GetType() == typeof(Author))
            {
                AddCreatedRecordToTable((Author)data);
            }
            if (data.GetType() == typeof(Category))
            {
                AddCreatedRecordToTable((Category)data);
            }
        }
        private void AddCreatedRecordToTable(Author author)
        {
            object[] rowData = ToAuthorRow(author);
            this.authorsTable.LoadDataRow(rowData, true);
        }
        private void AddCreatedRecordToTable(Category category)
        {
            object[] rowData = ToCategoryRow(category);
            this.categoryTable.LoadDataRow(rowData, true);
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
            if (!HasSelectedRow(this.authorsGridView))
            {
                return;
            }
            Object objId = this.authorsGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            int authorId = (int)objId;
            bool canNotDelete = this.repository.GetAuthorDao().IsBeingUsed(authorId);
            if (canNotDelete) 
            {
                MessageBox.Show("Author is being used and can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("Do you really want to delete selected author?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel) 
            {
                return;
            }
            this.repository.GetAuthorDao().DeleteAutor(authorId);
            uiState.LastModified = null;
            uiState.LastModifiedId = authorId;
            uiState.LastOperation = Operation.DELETE;
            RefreshGridData(this.authorsGridView);
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetActiveTabState();
        }
        private void SetActiveTabState() 
        {
            SetAutorsItemsState();
            SetCategoriesItemsState();
            SetLiteratureItemsState();
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
        private void SetCategoriesItemsState()
        {
            if (this.tabControl.SelectedTab == this.categoriesTab)
            {
                this.editViewCategoryToolStripMenuItem.Enabled = true;
                this.deleteCategotyToolStripMenuItem.Enabled = !readOnly;
            }
            else
            {
                this.editViewCategoryToolStripMenuItem.Enabled = false;
                this.deleteCategotyToolStripMenuItem.Enabled = false;
            }
        }

        private void SetLiteratureItemsState()
        {
            if (this.tabControl.SelectedTab == this.allLiteratureTab)
            {
                this.viewEditLiteratureToolStripMenuItem.Enabled = true;
                this.deleteLiteratureToolStripMenuItem.Enabled = !readOnly;
            }
            else
            {
                this.viewEditLiteratureToolStripMenuItem.Enabled = false;
                this.deleteLiteratureToolStripMenuItem.Enabled = false;
            }
        }

        private void AddNewCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCategory();
        }

        private void ViewEditCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditCategory();
        }

        private void DeleteCategotyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRow(this.categoriesGridView))
            {
                return;
            }
            Object objId = this.categoriesGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            int itemId = (int)objId;
            bool canNotDelete = this.repository.GetCategoryDao().IsBeingUsed(itemId);
            if (canNotDelete)
            {
                MessageBox.Show("Category is being used and can not be deleted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult res = MessageBox.Show("Do you really want to delete selected category?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            this.repository.GetCategoryDao().DeleteCategory(itemId);
            uiState.LastModified = null;
            uiState.LastModifiedId = itemId;
            uiState.LastOperation = Operation.DELETE;
            RefreshGridData(this.categoriesGridView);
        }

        private void ViewEditAuthor()
        {
            if (!HasSelectedRow(this.authorsGridView))
            {
                return;
            }
            Object objId = this.authorsGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            Author toEdit = this.repository.GetAuthorDao().GetById((int)objId);
            uiState.LastModified = toEdit;
            AddEditAuthorForm addEditAuthorForm = new AddEditAuthorForm(repository, uiState);
            addEditAuthorForm.ShowDialog();
            RefreshGridData(this.authorsGridView);
        }

        private void ViewEditCategory()
        {
            if (!HasSelectedRow(this.categoriesGridView))
            {
                return;
            }
            Object objId = this.categoriesGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            Category toEdit = this.repository.GetCategoryDao().GetById((int)objId);
            uiState.LastModified = toEdit;
            AddEditCategoryForm addEditCategoryForm = new AddEditCategoryForm(repository, uiState);
            addEditCategoryForm.ShowDialog();
            RefreshGridData(this.categoriesGridView);
        }

        private void ViewEditLiterature()
        {
            if (!HasSelectedRow(this.literatureGridView))
            {
                return;
            }
            Object objId = this.literatureGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            Literature toEdit = this.repository.GetLibraryDao().GetById((int)objId);
            uiState.LastModified = toEdit;
            AddEditLiteratureForm addEditLiteratureForm = new AddEditLiteratureForm(repository, uiState);
            addEditLiteratureForm.ShowDialog();
            RefreshGridData(this.literatureGridView);
        }

        private void AddLiteratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddLiterature();
        }

        private void AddLiterature()
        {
            uiState.LastModified = null;
            AddEditLiteratureForm addEditLiteratureForm = new AddEditLiteratureForm(repository, uiState);
            addEditLiteratureForm.ShowDialog();
            RefreshGridData(literatureGridView);
        }

        private void ViewEditLiteratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewEditLiterature();
        }

        private void DeleteLiteratureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRow(this.literatureGridView))
            {
                return;
            }
            Object objId = this.literatureGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            int itemId = (int)objId;
            DialogResult res = MessageBox.Show("Do you really want to delete selected literature?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (res == DialogResult.Cancel)
            {
                return;
            }
            this.repository.GetLibraryDao().DeleteLiterature(itemId);
            uiState.LastModified = null;
            uiState.LastModifiedId = itemId;
            uiState.LastOperation = Operation.DELETE;
            RefreshGridData(this.literatureGridView);
        }
    }



}
