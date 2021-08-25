using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DataLibrary;
using DataLibrary.DataAccess;

namespace FormsApp.Forms
{
    public partial class CategoryForm : Form
    {

        private List<Category> categories;
        public CategoryForm()
        {
           
            InitializeComponent();
            wireUp();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Category model = new Category(categoryNameTextBox.Text);
                SqlData db = new SqlData();
                db.CreateCategory(model);
                categoryNameTextBox.Text = "";
            }
            else
            {
                MessageBox.Show("Invalid form data");
            }
           
        }

        private bool ValidateForm()
        {
            bool output = true;
            if (categoryNameTextBox.Text.Length == 0)
            {
                output = false;
            }
            return output;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       private void wireUp()
        {
             SqlData db = new SqlData();
         
            categoryListBox.DataSource = db.GetCategory();
            categoryListBox.DisplayMember = "CategoryName";
        }
       
    }
}
