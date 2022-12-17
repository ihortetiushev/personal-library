using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public partial class AddEditLiteratureForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly bool editMode;
        private readonly Literature toEdit;
        private int? categoryId;
        public AddEditLiteratureForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            this.readOnly = this.uiState.LoggedInUser.Type == User.UserType.Reader;
            this.toEdit = (Literature)this.uiState.LastModified;
            this.editMode = toEdit != null;
            //PopulateEditingData();
        }

        private void SaveLiteratureButton_Click(object sender, EventArgs e)
        {
            if (readOnly)
            {
                this.uiState.LastModified = null;
                this.uiState.LastModifiedId = null;
                this.uiState.LastOperation = Operation.CANCEL;
                this.Close();
            }
            if (!editMode)
            {
                Literature created = CreateLiterature();
                if (created.LiteratureId > 0)
                {
                    this.uiState.LastModified = created;
                    this.uiState.LastModifiedId = created.LiteratureId;
                    this.uiState.LastOperation = Operation.CREATE;
                    this.Close();
                }
            }
            else
            {
                EditLiterature();
                this.uiState.LastModified = toEdit;
                this.uiState.LastModifiedId = toEdit.LiteratureId;
                this.uiState.LastOperation = Operation.UPDATE;
                this.Close();
            }
        }

        private void EditLiterature()
        {
            //TODO - implement
           /* toEdit.Name = this.categoryNameInput.Text;
            toEdit.Description = this.categoryDescriptionInput.Text;*/
            this.repository.GetLibraryDao().UpdateLiterature(toEdit);
        }

        private Literature CreateLiterature()
        {
            Literature literature = new Literature
            {
                LiteratureId = -1,
                Title = "smth"
            };
            this.repository.GetLibraryDao().CreateLiterature(literature);
            return literature;
        }

        private void CancelSavingLiteratureButton_Click(object sender, EventArgs e)
        {
            this.uiState.LastOperation = Operation.CANCEL;
            this.uiState.LastModified = null;
            this.uiState.LastModifiedId = null;
            this.Close();
        }

        private void SelectCategoryButton_Click(object sender, EventArgs e)
        {
            this.uiState.LastModifiedId = categoryId;
            CategorySelectionForm addEditLiteratureForm = new CategorySelectionForm(repository, uiState);
            addEditLiteratureForm.ShowDialog();
            if (uiState.LastOperation != Operation.CANCEL) 
            {
                Category selected = ((Category)uiState.LastModified);
                this.categoryLabel.Text = selected.Name;
                this.categoryId = selected.CategoryId;
            }
        }
    }
}
