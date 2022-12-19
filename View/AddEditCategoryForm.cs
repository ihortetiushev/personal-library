using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public partial class AddEditCategoryForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly bool editMode;
        private readonly Category toEdit;

        public AddEditCategoryForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            this.readOnly = this.uiState.LoggedInUser.Type == User.UserType.Reader;
            this.toEdit = (Category)this.uiState.LastModified;
            this.editMode = toEdit != null;
            PopulateEditingData();
        }

        private void PopulateEditingData()
        {
            if (toEdit != null)
            {
                this.Text = "Edit Author";
                this.categoryNameInput.Text = toEdit.Name;
                this.categoryDescriptionInput.Text = toEdit.Description;
                if (readOnly)
                {
                    this.Text = "View Category";
                    this.categoryNameInput.Enabled = false;
                    this.categoryDescriptionInput.Enabled = false;
                }
            }
        }
        private void SaveCategoryButton_Click(object sender, EventArgs e)
        {
            if (readOnly)
            {
                this.uiState.LastModified = null;
                this.uiState.LastModifiedId = null;
                this.uiState.LastOperation = Operation.CANCEL;
                this.Close();
                return;
            }
            if (!editMode)
            {
                Category created = CreateNewCategory();
                if (created.CategoryId > 0)
                {
                    this.uiState.LastModified = created;
                    this.uiState.LastModifiedId = created.CategoryId;
                    this.uiState.LastOperation = Operation.CREATE;
                    this.Close();
                }
            }
            else
            {
                EditCategory();
                this.uiState.LastModified = toEdit;
                this.uiState.LastModifiedId = toEdit.CategoryId;
                this.uiState.LastOperation = Operation.UPDATE;
                this.Close();
            }
        }
        private void EditCategory()
        {
            toEdit.Name = this.categoryNameInput.Text;
            toEdit.Description = this.categoryDescriptionInput.Text;
            this.repository.GetCategoryDao().UpdateCategory(toEdit);
        }
        private Category CreateNewCategory()
        {
            Category category = new Category
            {
                CategoryId = -1,
                Name = this.categoryNameInput.Text,
                Description = this.categoryDescriptionInput.Text,
            };
            this.repository.GetCategoryDao().CreateCategory(category);
            return category;
        }
        private void CancelSaveCategoryButton_Click(object sender, EventArgs e)
        {
            this.uiState.LastOperation = Operation.CANCEL;
            this.uiState.LastModified = null;
            this.uiState.LastModifiedId = null;
            this.Close();
        }
    }
}
