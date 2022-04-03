using System.Collections.Generic;
using System.Linq;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Dapper;

namespace DataLibraryEmployees.DataAccess
{
    public static class SqlDataAccess
    {
        public static string getConnectioString(string connectionName= "MVCDemoDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }
        public static List<T> LoadData<T>(string sql)
        {
            using (IDbConnection cnn= new SqlConnection(getConnectioString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }
        public static int SaveData<T>(string sql, T Data)
        {
            using (IDbConnection cnn = new SqlConnection(getConnectioString()))
            {
                return cnn.Execute(sql, Data);
            }
        }
    }
}
