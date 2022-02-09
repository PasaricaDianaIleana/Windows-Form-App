using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.Forms
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

     private bool CheckData()
        {
            bool result = true;
            if (string.IsNullOrEmpty(userNameTxtBox.Text))
            {

                result = false;
                MessageBox.Show("UserName is required");
            }
            if (string.IsNullOrEmpty(passwordTxtInput.Text))
            {
                result=false;
                MessageBox.Show("Password is required"); 
            }
            if (string.IsNullOrEmpty(emailTextBox.Text))
            {
                result = false;
                MessageBox.Show("Email is required");
            }
            if (string.IsNullOrEmpty(phoneTextBox.Text))
            {
                result = false;
                MessageBox.Show("Phone number is required");

            }
            if (string.IsNullOrEmpty(cityTextBox.Text))
            {
                result = false;
                MessageBox.Show("City is required");
            }
            return result;

        }
    }
}
