using DataLibrary.Models;
using System;
using System.Collections.Generic;

namespace DataLibrary
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Products> Products { get; set; } = new List<Products>();

        public Category()
        {

        }
        public Category(string categoryName):this()
        {
            CategoryName = categoryName;
        }
        public Category(int id, string categoryName) : this()
        {
            CategoryName = categoryName;
            CategoryId = id;
        }
    }
}
