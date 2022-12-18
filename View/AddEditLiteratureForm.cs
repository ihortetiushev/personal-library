using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static PersonalLibrary.View.UIHelper;

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
        private Dictionary<int, Author> authors = new Dictionary<int, Author>();

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
                if (!ValidateData())
                {
                    return;
                }
                Literature created = CreateLiterature();
                if (created == null) 
                {
                    return;
                }
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
                CategoryId = this.categoryId.Value,
                Title = this.titleText.Text.Trim(),
                ISBN = this.isbnText.Text.Trim(),
                Publisher = this.publisherText.Text.Trim(),
                Authors = authors.Values.ToList()
            };
            if (this.repository.GetLibraryDao().CreateLiterature(literature)) 
            {
                return literature;
            }
            return null;
        }
        private bool ValidateData() 
        {
            if (this.categoryId == null) 
            {
                MessageBox.Show("Category must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.titleText.Text.Trim().Length == 0) 
            {
                MessageBox.Show("Title must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (this.authors.Count == 0)
            {
                MessageBox.Show("Literature must have at least single author", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
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
            CategorySelectionForm categorySelectionForm = new CategorySelectionForm(repository, uiState);
            categorySelectionForm.ShowDialog();
            if (uiState.LastOperation != Operation.CANCEL) 
            {
                Category selected = ((Category)uiState.LastModified);
                this.categoryLabel.Text = selected.Name;
                this.categoryId = selected.CategoryId;
            }
        }

        private void AddAuthorButton_Click(object sender, EventArgs e)
        {
            Author last = authors.Count > 0 ? authors.Values.Last() : null;
            int? lastAuthorId = null;
            if (last != null) 
            {
                lastAuthorId = last.AuthorId;
            }
            this.uiState.LastModifiedId = lastAuthorId;
            AuthorSelectionForm authorSelectionForm = new AuthorSelectionForm(repository, uiState);
            authorSelectionForm.ShowDialog();
            if (uiState.LastOperation != Operation.CANCEL)
            {
                Author selected = ((Author)uiState.LastModified);
                authors[selected.AuthorId] = selected;
                List<Author> allAuthors = authors.Values.ToList();
                PopulateAutorGridData(allAuthors, this.literatureAuthorsGridView);
            }
        }

        private void RemoveAuthorButton_Click(object sender, EventArgs e)
        {
            if (!HasSelectedRow(literatureAuthorsGridView))
            {
                return;
            }
            DataGridViewSelectedRowCollection selected = literatureAuthorsGridView.SelectedRows;
            object idObj = selected[0].Cells[ID_COLUMN_INDEX].Value;
            literatureAuthorsGridView.Rows.RemoveAt(selected[0].Index);
            this.authors.Remove((int)idObj);
        }
    }
}
