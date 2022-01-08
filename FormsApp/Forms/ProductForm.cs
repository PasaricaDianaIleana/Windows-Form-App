using DataLibrary;
using DataLibrary.DataAccess;
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
    public partial class ProductForm : Form
    {
        private List<Category> availableCategories = new List<Category>();
        public ProductForm()
        {
            InitializeComponent();
            LoadListData();
            WireUpList();
        }

        private void LoadListData()
        {
            SqlData db = new SqlData();
            availableCategories = db.GetCategory();
        }
        private void WireUpList()
        {
            categoriesComboBox.DataSource = availableCategories;
            categoriesComboBox.DisplayMember = "CategoryName";
            categoriesComboBox.ValueMember = "CategoryId";

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private bool CheckData()
        {
            bool output = true;
            if (String.IsNullOrEmpty(productNameTextBox.Text))
            {
                MessageBox.Show("Product name field can't be empty");
                output = false;
            }
            bool priceCheck = decimal.TryParse(priceTextBox.Text, out decimal result);
            if (priceCheck || result==0)
            {
                MessageBox.Show("Price field must be a number");
                output=false;
            }
            bool quantityCheck = int.TryParse(quantityTextBox.Text, out int quantity);
            if (!quantityCheck ||  quantity==0)
            {
                MessageBox.Show("Quantity field field must be a number");
                output = false;
            }
            if(categoriesComboBox.SelectedIndex == 0)
            {
                MessageBox.Show("A category must be selected");
                output = false;
            }
            return output;

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
             CategoryForm form= new CategoryForm();
            form.ShowDialog();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                MessageBox.Show("Data is correct");
            }
        }
    }
}
