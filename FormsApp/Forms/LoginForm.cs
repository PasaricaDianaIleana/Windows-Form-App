using DataLibrary.DataAccess;
using DataLibrary.Models;
using FormsApp.Forms;
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
        enum Role
        {
            Admin,
            Seller,
            User
        }
     
        public LoginForm()
        {
            InitializeComponent();
            WireUpComboBox();
        }
        public void WireUpComboBox()
        {
          roleComboBox.DataSource = Enum.GetValues(typeof(Role)); 

        }
        private void exitLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (CheckUser())
            {
                try
                {
                    SqlData db = new SqlData();
                    string userRole = roleComboBox.SelectedValue.ToString();
                    Login model = new Login(userNameTxtBox.Text, passwordTxtInput.Text, userRole);
                    var result=db.Login(model);
                    if (result == 1 && userRole == "Admin")
                    {
                        this.Hide();
                        ProductForm form = new ProductForm();
                        form.ShowDialog();
                        
                    }
                    else if(result == 1 && userRole == "User")
                    {
                        this.Hide();
                        SellerForm form= new SellerForm();
                        form.Show();
                        
                    }
                    else
                    {
                        MessageBox.Show("UserName or password is wrong");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    throw ex;
                 
                }
            }
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

        private void registerLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterForm form = new RegisterForm();
            form.Show();
        }
    }
}
