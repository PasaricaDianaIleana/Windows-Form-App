using Dapper;
using DataLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLibrary.DataAccess
{
    public class SqlData : IDataRepository
    {
        public Register AddUser(Register model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                 var p = new DynamicParameters();
                p.Add("@UserName", model.UserName);
                p.Add("@Email", model.Email);
                p.Add("@PhoneNumber", model.PhoneNumber);
                p.Add("@City", model.City);
                p.Add("UserId",0, dbType:DbType.Int32, direction:ParameterDirection.Output);

                connection.Execute("dbo.spAddUser", p, commandType: CommandType.StoredProcedure);
                model.UserId = p.Get<int>("@UserId");
                return model;
            }
      }
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

        public int Login(Login login)
        {
            var result=0;
            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                var p = new DynamicParameters();
                p.Add("@UserName", login.UserName);
                p.Add("@PassWord",login.Password);
                p.Add("@Role", login.UserRole);
                result = connection.Execute("dbo.GetUsers_sp",p, commandType:CommandType.StoredProcedure);
            }
            return result;
        }

        public void UpdateCategory(Category model, int categoryId)
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

        public void UpdateProduct(Products model, int productdId)
        {
            using (IDbConnection connection= new System.Data.SqlClient.SqlConnection(Helper.ConnectionStringVal("ShopDB")))
            {
                //dbo.spUpdateProduct
                // @ProductId int
                var p = new DynamicParameters();
                p.Add("@ProductName", model.ProdName);
                p.Add("@Price", model.Price);
                p.Add("@Quantity", model.ProdQTY);
                p.Add("@CategoryId", model.CategoryId);
                p.Add("ProductId", model.ProdId);
                p.Add("@ProductName", model.ProdName);
                connection.Execute("dbo.spUpdateProduct", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
