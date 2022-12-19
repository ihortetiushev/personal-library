using PersonalLibrary.Dao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using static PersonalLibrary.View.UIHelper;

namespace PersonalLibrary.View
{
    public abstract partial class ReferenceSelectionForm<T> : Form
    {
        protected readonly Repository repository;
        private readonly UIState uiState;
        public ReferenceSelectionForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            LoadDataInternal();
            SetSelectedRow();
        }
        protected abstract List<T> LoadData();
        protected abstract DataTable CreateDataTable(DataGridView gridView);
        protected abstract object[] ToDataRow(T data);
        protected DataTable PopulateDataGridData(List<T> data, DataGridView gridView)
        {
            DataTable table = CreateDataTable(gridView);
            foreach (T dataItem in data)
            {
                table.LoadDataRow(ToDataRow(dataItem), true);
            }
            return table;
        }
        private void LoadDataInternal()
        {
            Cursor oldCur = Cursor.Current;
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                List<T> data = LoadData();
                PopulateDataGridData(data, this.dataSelectionGridView);
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
            dataSelectionGridView.ClearSelection();
            foreach (DataGridViewRow row in dataSelectionGridView.Rows)
            {

                Object objId = row.Cells[ID_COLUMN_INDEX].Value;
                if (currentCategoryId == (int)objId)
                {
                    row.Selected = true;
                    dataSelectionGridView.CurrentCell = dataSelectionGridView.Rows[row.Index].Cells[0];
                }
            }
        }
        protected abstract T loadSelectItem(int itemId);
        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRow(dataSelectionGridView))
            {
                return;
            }
            Object objId = dataSelectionGridView.CurrentRow.Cells[ID_COLUMN_INDEX].Value;
            int objIdInt = (int)objId;
            T selected = loadSelectItem(objIdInt);
            this.uiState.LastOperation = Operation.SELECTION;
            this.uiState.LastModifiedId = objIdInt;
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
