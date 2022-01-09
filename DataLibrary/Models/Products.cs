﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.Models
{
  public  class Products
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int CategoryId { get; set; }

        public Products(string name, decimal price, int quantity, int categoryId)
        {
            ProductName = name;
            Price = price;
            Quantity = quantity;
            CategoryId = categoryId;

        }
    }
}
