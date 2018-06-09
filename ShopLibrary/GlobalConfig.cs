using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using ShopLibrary.DataAccess;
using ShopLibrary.Models;
using System.Globalization;
using System.Resources;
using System.Threading.Tasks;

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

        public static CultureInfo Culture = CultureInfo.CreateSpecificCulture("en");
        public static ResourceManager ResourceManager;
        #endregion

        public static void InitializeConnections(bool sqlDb, bool mongoDb, bool jsonDb) {
            Connection = new List<IDataConnection>();
            if (mongoDb)
            {
                Debug.WriteLine("Mongo Trying to Initialize Mongo Connector");
                var mongo = new MongoConnector();
                Debug.WriteLine("Adding MongoConnector to Connections");
                Connection.Add(mongo);
            }
        }

        public static void LoadBasicDatabase()
        {
            Users = Connection[0].GetUserAll();
            if (Users.Count == 0)
            {
                Connection[0].InsertUser(new User("brotality"));
                Users = Connection[0].GetUserAll();
            }
            var sw = Stopwatch.StartNew();
            BankAccounts = Connection[0].GetBankAccountsAll();
            CurrentCash = Connection[0].GetCurrentCash();
            Shops = Connection[0].GetShopsAll();
            Employees = Connection[0].GetEmployeeAll();
            Customers = Connection[0].GetCustomersAll();
            Suppliers = Connection[0].GetSupplierAll();
            Categories = Connection[0].GetCategoryAll();
            Products = Connection[0].GetProductsAll(); 
            Debug.WriteLine("Tasks took {0}", sw.Elapsed);
            sw           = Stopwatch.StartNew();
            BankAccounts = Task.Factory.StartNew(() => Connection[0].GetBankAccountsAll()).Result;
            CurrentCash  = Task.Factory.StartNew(() => Connection[0].GetCurrentCash()).Result;
            Shops        = Task.Factory.StartNew(() => Connection[0].GetShopsAll()).Result;
            Employees    = Task.Factory.StartNew(() => Connection[0].GetEmployeeAll()).Result;
            Customers    = Task.Factory.StartNew(() => Connection[0].GetCustomersAll()).Result;
            Suppliers    = Task.Factory.StartNew(() => Connection[0].GetSupplierAll()).Result;
            Categories   = Task.Factory.StartNew(() => Connection[0].GetCategoryAll()).Result;
            Products     = Task.Factory.StartNew(() => Connection[0].GetProductsAll()).Result;
            Debug.WriteLine("Sync took {0}", sw.Elapsed);
        }

        public static string CnnString(string name) => ConfigurationManager.ConnectionStrings[name].ConnectionString;

        public static void Init()
        {
            try {
                InitializeConnections(false, true, false);
                LoadBasicDatabase();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}