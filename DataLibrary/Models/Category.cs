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
    }
}
