using Dapper;
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
    }
}
