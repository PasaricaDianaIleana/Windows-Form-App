using System;
using System.Windows.Forms;
using DataLibrary;
using DataLibrary.DataAccess;

namespace FormsApp.Forms
{
    public partial class CategoryForm : Form
    {

        public CategoryForm()
        {
           
            InitializeComponent();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Category model = new Category(categoryNameTextBox.Text);
                SqlData db = new SqlData();
                db.CreateCategory(model);
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
    }
}
