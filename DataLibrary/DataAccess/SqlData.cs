using Dapper;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public class SqlData : IDataRepository
    {
        public Category CreateCategory(Category model)
        {
            using (IDbConnection connection = 
                new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var c = new DynamicParameters();
                c.Add("@CategoryName", model.CategoryName);
                c.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spCategory_Insert",c,commandType:CommandType.StoredProcedure);
                model.CategoryId = c.Get<int>("@id");
                return model;
            }
        }

        public Products CreateProduct(Products model)
        {
            using(IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var product= new DynamicParameters();
                product.Add("@Name", model.ProdName);
                product.Add("@Price", model.Price);
                product.Add("@Quantity", model.ProdQTY);
                product.Add("@Category", model.CategoryId);
                product.Add("ProductId",0, DbType.Int32, direction: ParameterDirection.Output);
                
                connection.Execute("dbo.InsertProduct_sp", product, commandType:CommandType.StoredProcedure);
                model.ProdId = product.Get<int>("@ProductId");
                return model;
            }
        }

        public void DeleteCategory(int id)
        {
         using (IDbConnection connection=
                new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var c = new DynamicParameters();
                c.Add("@Id", id);
                connection.Execute("dbo.spDeleteCategory", c, commandType: CommandType.StoredProcedure);
                
            }
        }

        public void DeleteProduct(int id)
        {
            using (IDbConnection connection =
                new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var c = new DynamicParameters();
                c.Add("@Id", id);
                connection.Execute("dbo.spDeleteProduct", c, commandType: CommandType.StoredProcedure);

            }
        }

        public List<Category> GetCategory()
        {
            List<Category> output;
            using (IDbConnection connection= 
                new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                output = connection.Query<Category>("dbo.spGetCategory").ToList();
            }
            return output;
        }
        public List<Products> GetProducs()
        {
            List<Products> output;
            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                output = connection.Query<Products>("dbo.spGetProducts").ToList();
            }
            return output;
        } 
        public void UpdateCategory(Category model)
        {
            //dbo.spEditCategory @CategoryName, @CategoryId
            using (IDbConnection  connection =
                new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var p = new DynamicParameters();
                p.Add("@CategoryName", model.CategoryName);
                p.Add("@CategoryId", model.CategoryId);
                connection.Execute("dbo.spEditCategory", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
