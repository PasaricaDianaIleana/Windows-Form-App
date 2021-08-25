using DataLibrary.DataAccess;
using System.Configuration;

namespace DataLibrary
{
    public static class Helper
    {
        public static IDataRepository Connection { get; private set; }
        public static string ConnectionStringVal(string name)
        {
           return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
