using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {

        }
        private bool CheckUser()
        {
            bool result = true;
            if (String.IsNullOrEmpty(userNameTxtBox.Text))
            {
                MessageBox.Show("UserName is required");
                result= false;
            }
            if (String.IsNullOrEmpty(passwordTxtInput.Text))
            {
                MessageBox.Show("Password is required");
                result = false;
            }
            if (roleComboBox.SelectedItem == null)
            {
                MessageBox.Show("Please select login role");
                result = false;
            }
            return result;
        }
    }
}
