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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
