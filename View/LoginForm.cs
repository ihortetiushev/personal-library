using PersonalLibrary.Dao;
using System;
using System.Windows.Forms;

namespace PersonalLibrary.View
{
    public partial class LoginForm : Form
    {
        public LoginForm(Repository repository, UIState uiState)
        {
            InitializeComponent();
            SetInitialState();
            this.repository = repository;
            this.uiState = uiState;
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
    }
}
