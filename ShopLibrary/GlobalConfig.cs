using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using ShopLibrary.DataAccess;
using ShopLibrary.Models;

namespace ShopLibrary {
    public static class GlobalConfig {
        #region Global Variables
        public static Session CurrentSession;
        public static User CurrentUser = new User();
        public static List<BankAccount> BankAccounts;
        public static List<Category> Categories;
        public static List<Customer> Customers;
        public static List<Employee> Employees;
        public static List<Product> Products;
        public static List<Shop> Shops;
        public static List<Supplier> Suppliers;
        public static List<User> Users;
        public static Cash CurrentCash;
        public static List<IDataConnection> Connection { get; set; }

        public static readonly log4net.ILog log = LogHelper.GetLogger();
        #endregion

        public static void InitializeConnections(bool sqlDb, bool mongoDb, bool jsonDb) {
            Connection = new List<IDataConnection>();
            if (sqlDb) {
                SqlConnector sql = new SqlConnector();
                Connection.Add(sql);
            }

            if (mongoDb)
            {
                Debug.WriteLine("Mongo Trying to Initialize Mongo Connector");
                MongoConnector mongo = new MongoConnector();
                Debug.WriteLine("Adding MongoConnector to Connections");
                Connection.Add(mongo);
            }

            if (jsonDb)
            {
                JsonConnector json = new JsonConnector();
                Connection.Add(json);
            }
        }

        public static string CnnString(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;
    }
}