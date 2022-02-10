using DataLibrary.DataAccess;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp.Forms
{
    public partial class RegisterForm : Form
    {
        enum Role
        {
            User, 
            Seller
        }
       
        public RegisterForm()
        {
            InitializeComponent();
            WireUpComboBox();
        }
     private void WireUpComboBox()
        {
            roleComboBox.DataSource = Enum.GetValues(typeof(Role));
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
        private void ClearInput()
        {
            userNameTxtBox.Text = string.Empty;
            passwordTxtInput.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            phoneTextBox.Text = string.Empty;
            cityTextBox.Text = string.Empty;
            
        }
        private void regsiterButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    SqlData db = new SqlData();
                    string userRole = roleComboBox.SelectedValue.ToString();
                    Register model = new Register(
                    userNameTxtBox.Text,passwordTxtInput.Text,emailTextBox.Text,phoneTextBox.Text,
                    cityTextBox.Text, userRole );
                    db.AddUser(model);
                    ClearInput();
                    MessageBox.Show("Register succeed");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
           
        }
    }
}
