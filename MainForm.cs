using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace personal_library
{
    public partial class MainForm : Form
    {
        public MainForm(LoginForm loginForm)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            LoadData();
        }

        private LoginForm loginForm;

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {

            var result = MessageBox.Show("Do you want to exit?", "Confirm exit",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
            loginForm.Close();
        }
        private void LoadData()
        {
            string connectionString = "data source=LAPTOP-EENRFF17\\SQLEXPRESS;initial catalog = course_project; User ID=lib_db_user;Password=123456;";
            SqlConnection cnn = new SqlConnection(connectionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Can not open connection ! " + ex.Message);
            }
        }
    }
}
