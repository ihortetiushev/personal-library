using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static PersonalLibrary.View.UIHelper;

namespace PersonalLibrary.View
{
    public partial class CategorySelectionForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private DataTable categoryTable;
        public CategorySelectionForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            LoadData();
            SetSelectedRow();
        }

        private void LoadData()
        {
            Cursor oldCur = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<Category> categories = this.repository.GetCategoryDao().GetAllCategories();
                this.categoryTable = PopulateCategoryGridData(categories, this.categorySelectionGridView);
                Cursor.Current = oldCur;
            }
            catch (Exception ex)
            {
                Cursor.Current = oldCur;
                MessageBox.Show("Error loading data!:" + ex.Message);
            }
        }
        private void SetSelectedRow() 
        {
            int? currentCategoryId = this.uiState.LastModifiedId;
            if (currentCategoryId == null) 
            {
                return;
            }
            categorySelectionGridView.ClearSelection();
            foreach (DataGridViewRow row in categorySelectionGridView.Rows)
            {

                Object objId = row.Cells[ID_COLUMN_INDEX].Value;
                if (currentCategoryId == (int)objId)
                {
                    row.Selected = true;
                    categorySelectionGridView.CurrentCell = categorySelectionGridView.Rows[row.Index].Cells[0];
                }
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRow(this.categorySelectionGridView))
            {
                return;
            }
            Object objId = this.categorySelectionGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            int categoryId = (int)objId;
            Category selected = this.repository.GetCategoryDao().GetById(categoryId);
            this.uiState.LastOperation = Operation.SELECTION;
            this.uiState.LastModifiedId = categoryId;
            this.uiState.LastModified = selected;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            uiState.LastModified = null;
            uiState.LastModifiedId = null;
            uiState.LastOperation = Operation.CANCEL;
            this.Close();
        }
    }
}
