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
    public partial class SellerForm : Form
    {
        private List<Category> availableCategories = new List<Category>();
        public SellerForm()
        {
            InitializeComponent();
            WireUpForm();
            WireUpList();
        }
        private void WireUpList()
        {
            SqlData db=new SqlData();
            availableCategories = db.GetCategory();
            filterBox.DataSource = availableCategories;
            filterBox.DisplayMember = "CategoryName";
            filterBox.ValueMember = "CategoryId";
        }
        private void WireUpForm()
        {
            SqlData db = new SqlData();
            var products=db.GetProducs();
            var productAvailable = "Unavailable";
            foreach (var product in products)
            {
                if (product.Available == true)
                {
                    productAvailable = "Available";
                }
                AddProductToList(product.ProdName, product.ProdQTY.ToString(), product.Price.ToString(),product.CategoryName, productAvailable);
            }
        }
        private void AddProductToList(string name, string price, string quantity, string categoryName, string available)
        {
            //new ListViewItem(new string[] { name, price, quantity, categoryName });
            listViewProducts.Items.Add(new ListViewItem(new[] { name, price, quantity, categoryName, available }));
        }
        private void showItemsCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            SqlData db = new SqlData();
            List<Products> products = new List<Products>();
            var checkBoxValue = showItemsCheckBox1.Checked;
            var productAvailable = "Unavailable";
            products = db.GetAvailableProducts(checkBoxValue);
            if (checkBoxValue == true)
            {
                foreach (var product in products)
                {
                    listViewProducts.Items.Clear();
                    if (product.Available == true)
                    {
                        productAvailable = "Available";
                    }
                    AddProductToList(product.ProdName, product.ProdQTY.ToString(), product.Price.ToString(), product.CategoryName, productAvailable);

                }
            }
            else
            {
                listViewProducts.Items.Clear();
                WireUpForm();
            }
        }

        private void filterBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlData db = new SqlData();
            List<Products> products = new List<Products>();
            var productAvailable = "Unavailable";
            int.TryParse(filterBox.SelectedValue.ToString(), out int categorySelected);
            products = db.ApplyFiltere(categorySelected);
           
            foreach (var product in products)
            {
                listViewProducts.Items.Clear();
                if (product.Available == true)
                {
                    productAvailable = "Available";
                }
                AddProductToList(product.ProdName, product.ProdQTY.ToString(), product.Price.ToString(), product.CategoryName, productAvailable);

            }
        }
    }
}
