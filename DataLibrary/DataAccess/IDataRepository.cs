using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
   public interface IDataRepository
    {
        Category CreateCategory(Category model);
        List<Category> GetCategory();

        void DeleteCategory(int id);

        void UpdateCategory(Category model, int categoryId);

        Products CreateProduct(Products model);

        void DeleteProduct(int id);

        void UpdateProduct(Products model, int productId);
      }
}
