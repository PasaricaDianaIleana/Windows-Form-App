using System;
using System.Collections.Generic;
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
            wireUp();
            
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                Category model = new Category(categoryNameTextBox.Text);
                SqlData db = new SqlData();
                db.CreateCategory(model);
                AddToList(model.CategoryId.ToString(), model.CategoryName);
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
            var data=db.GetCategory();
            for(int i = 0; i < data.Count; i++)
            {

                AddToList(data[i].CategoryId.ToString(), data[i].CategoryName);
                listViewCategory.FullRowSelect = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlData db = new SqlData();
            db.DeleteCategory(int.Parse(listViewCategory.SelectedItems[0].Text));
            listViewCategory.Items.Clear();
            wireUp();
        }

      private void AddToList(string categoryId,string Name)
        {
            listViewCategory.Items.Add(new ListViewItem(new string[] { categoryId, Name }));
        }
    }
}
