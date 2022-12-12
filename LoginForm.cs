using PersonalLibrary.Dao;
using PersonalLibrary.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalLibrary
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
