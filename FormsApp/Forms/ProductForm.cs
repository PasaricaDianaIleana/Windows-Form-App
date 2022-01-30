using DataLibrary;
using DataLibrary.DataAccess;
using DataLibrary.Models;
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
            WireUpList();
            WireUpForm();
        }
        private void WireUpList()
        {
            SqlData db = new SqlData();
            availableCategories = db.GetCategory();
            categoriesComboBox.DataSource = availableCategories;
            categoriesComboBox.DisplayMember = "CategoryName";
            productsListView.Columns[4].Width = 0;
            categoriesComboBox.ValueMember = "CategoryId";

        }
        private void WireUpForm()
        {
            SqlData db = new SqlData();
            var data = db.GetProducs();
            foreach(var product in data)
            {
                AddProductToList(product.ProdName, product.Price.ToString(), product.ProdQTY.ToString(), product.CategoryName, product.ProdId.ToString());
                productsListView.FullRowSelect = true;
            }
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
            if (!priceCheck || result==0)
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
            if(categoriesComboBox.SelectedItem == null)
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
                decimal.TryParse(priceTextBox.Text, out decimal result);
                int.TryParse(quantityTextBox.Text, out int quantity);
                int.TryParse(categoriesComboBox.SelectedValue.ToString(), out int id);
                Products model = new Products(productNameTextBox.Text,result,quantity,id);
                SqlData db = new SqlData();
                db.CreateProduct(model);
                clearTextBox();
                AddProductToList(model.ProdName, model.Price.ToString(), model.ProdQTY.ToString(), categoriesComboBox.Text, model.ProdId.ToString());
                
            }
            else
            {
                MessageBox.Show("Invalid form data");
            }
        }
        private void AddProductToList(string name, string price,string quantity, string categoryName, string productId)
        {
            //new ListViewItem(new string[] { name, price, quantity, categoryName });
            productsListView.Items.Add(new ListViewItem(new[] { name, price, quantity, categoryName, productId }));
        }

        private void productsListView_SelectedItem(object sender, EventArgs e)
        {
            if (productsListView.SelectedItems.Count == 0)
            {
                return;
            }
            else
            {
                try
                {
                    ListViewItem item = productsListView.SelectedItems[0];
                    productNameTextBox.Text = item.SubItems[0].Text;
                    priceTextBox.Text = item.SubItems[1].Text;
                    quantityTextBox.Text = item.SubItems[2].Text;
                    categoriesComboBox.Text = item.SubItems[3].Text;
                   

                    
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
            }
        }
        private void clearTextBox()
        {
            productNameTextBox.Text = "";
            priceTextBox.Text = "";
            quantityTextBox.Text = "";
            categoriesComboBox.Text = "";
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            SqlData db = new SqlData();
            ListViewItem item = productsListView.SelectedItems[0];
            db.DeleteProduct(int.Parse(item.SubItems[4].Text));
            productsListView.Items.Clear();
            clearTextBox();
            WireUpForm();
        }
    }
}
