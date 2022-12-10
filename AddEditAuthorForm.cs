using PersonalLibrary;
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
        public AddEditAuthorForm(MainForm parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void CancelSaveAutorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveAuthorButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool CreateNewAuthor() 
        {
            return false;// parentForm.auto

        }
    }
}
