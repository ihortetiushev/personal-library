using PersonalLibrary.Dao;
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
        public LoginForm(Repository repository)
        {
            InitializeComponent();
            SetInitialState();
            this.repository = repository;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            DoLogin();
        }
    }
}
