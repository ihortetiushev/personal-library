using PersonalLibrary;
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

namespace personal_library
{
    public partial class AddEditAuthorForm : Form
    {
        private readonly MainForm parentForm;
        private readonly Repository repository;
        public AddEditAuthorForm(MainForm parentForm, Repository repository)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.repository = repository;
        }

        private void CancelSaveAutorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAuthorButton_Click(object sender, EventArgs e)
        {
            if (CreateNewAuthor())
            {
                this.Close();
            }
        }
        private bool CreateNewAuthor() 
        {
            Author author = new Author
            {
                AuthorId = -1,
                FirstName = this.authorFirstNameInput.Text,
                LastName = this.authorLastNameInput.Text,
                Comment = this.authorCommentInput.Text
            };
            this.repository.GetAuthorDao().CreateAuthor(author);
            return author.AuthorId > 0;
        }
    }
}
