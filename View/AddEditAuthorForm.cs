using PersonalLibrary.Dao;
using PersonalLibrary.Models;
using System;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public partial class AddEditAuthorForm : Form
    {
        private readonly Repository repository;
        private readonly UIState uiState;
        private readonly bool readOnly;
        private readonly bool editMode;
        private readonly Author toEdit;
        public AddEditAuthorForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            this.repository = repository;
            this.uiState = uiState;
            this.readOnly = this.uiState.LoggedInUser.Type == User.UserType.Reader;
            this.toEdit = (Author)this.uiState.LastModified;
            this.editMode = toEdit != null;
            PopulateEditingData();
        }

        private void PopulateEditingData()
        {
            if (toEdit != null)
            {
                this.Text = "Edit Author";
                this.authorFirstNameInput.Text = toEdit.FirstName;
                this.authorLastNameInput.Text = toEdit.LastName;
                this.authorCommentInput.Text = toEdit.Comment;
                if (readOnly)
                {
                    this.Text = "View Author";
                    this.authorFirstNameInput.Enabled = false;
                    this.authorLastNameInput.Enabled = false;
                    this.authorCommentInput.Enabled = false;
                }
            }
        }
        private void CancelSaveAutorButton_Click(object sender, EventArgs e)
        {
            this.uiState.LastOperation = Operation.CANCEL;
            this.uiState.LastModified = null;
            this.uiState.LastModifiedId = null;
            this.Close();
        }
        private void SaveAuthorButton_Click(object sender, EventArgs e)
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
                Author created = CreateNewAuthor();
                if (created.AuthorId > 0)
                {
                    this.uiState.LastModified = created;
                    this.uiState.LastModifiedId = created.AuthorId;
                    this.uiState.LastOperation = Operation.CREATE;
                    this.Close();
                }
            }
            else
            {
                EditAuthor();
                this.uiState.LastModified = toEdit;
                this.uiState.LastModifiedId = toEdit.AuthorId;
                this.uiState.LastOperation = Operation.UPDATE;
                this.Close();
            }

        }
        private void EditAuthor()
        {
            toEdit.FirstName = this.authorFirstNameInput.Text;
            toEdit.LastName = this.authorLastNameInput.Text;
            toEdit.Comment = this.authorCommentInput.Text;
            this.repository.GetAuthorDao().UpdateAuthor(toEdit);
        }
        private Author CreateNewAuthor()
        {
            Author author = new Author
            {
                AuthorId = -1,
                FirstName = this.authorFirstNameInput.Text,
                LastName = this.authorLastNameInput.Text,
                Comment = this.authorCommentInput.Text
            };
            this.repository.GetAuthorDao().CreateAuthor(author);
            return author;
        }
    }
}
