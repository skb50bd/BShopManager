using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Driver;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.DataAccess {
    public class BackUpDatabase
    {
        private static MongoClient client;
        private static IMongoDatabase db;
        private static List<BankAccount> BankAccounts;
        private static List<Category> Categories;
        private static List<Customer> Customers;
        private static List<DebtCollection> DebtCollections;
        private static List<Employee> Employees;
        private static List<Expense> Expenses;
        private static List<Payment> Payments;
        private static List<Product> Products;
        private static List<Purchase> Purchases;
        private static List<Purchase> SavedPurchases;
        private static List<Repayment> Repayments;
        private static List<Sale> Sales;
        private static List<Sale> SavedSales;
        private static List<Shop> Shops;
        private static List<Supplier> Suppliers;
        private static List<Transaction> Transactions;
        private static List<User> Users;


        public static void ToJson(string path)
        {
            client = new MongoClient(CnnString("MongoShopDb"));
            db = client.GetDatabase("MongoShopDb");

            // Getting the all data from database

            BankAccounts    = db.GetCollection<BankAccount>("BankAccount").Find(new BsonDocument()).ToList();
            Categories      = db.GetCollection<Category>("Category").Find(new BsonDocument()).ToList();
            Customers       = db.GetCollection<Customer>("Customer").Find(new BsonDocument()).ToList();
            DebtCollections = db.GetCollection<DebtCollection>("DebtCollection").Find(new BsonDocument()).ToList();
            Employees       = db.GetCollection<Employee>("Employee").Find(new BsonDocument()).ToList();
            Expenses        = db.GetCollection<Expense>("Expense").Find(new BsonDocument()).ToList();
            Payments        = db.GetCollection<Payment>("Payment").Find(new BsonDocument()).ToList();
            Products        = db.GetCollection<Product>("Product").Find(new BsonDocument()).ToList();
            Purchases       = db.GetCollection<Purchase>("Purchase").Find(new BsonDocument()).ToList();
            Repayments      = db.GetCollection<Repayment>("Repayment").Find(new BsonDocument()).ToList();
            Sales           = db.GetCollection<Sale>("Sale").Find(new BsonDocument()).ToList();
            SavedPurchases  = db.GetCollection<Purchase>("SavedPurchase").Find(new BsonDocument()).ToList();
            SavedSales      = db.GetCollection<Sale>("SavedSale").Find(new BsonDocument()).ToList();
            Shops           = db.GetCollection<Shop>("Shop").Find(new BsonDocument()).ToList();
            Suppliers       = db.GetCollection<Supplier>("Supplier").Find(new BsonDocument()).ToList();
            Transactions    = db.GetCollection<Transaction>("Transaction").Find(new BsonDocument()).ToList();
            Users           = db.GetCollection<User>("User").Find(new BsonDocument()).ToList();

            // Ends

            path += DateTime.Now.ToString("yyyymmddHHmmss");
            //Saving data to Json
            //System.IO.File.WriteAllText(path + @"BankAccounts.json", JsonConvert.SerializeObject(BankAccounts.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Categories.json", JsonConvert.SerializeObject(Categories.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Customers.json", JsonConvert.SerializeObject(Customers.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"DebtCollections.json", JsonConvert.SerializeObject(DebtCollections.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Employees.json", JsonConvert.SerializeObject(Employees.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Expenses.json", JsonConvert.SerializeObject(Expenses.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Payments.json", JsonConvert.SerializeObject(Payments.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Products.json", JsonConvert.SerializeObject(Products.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Purchases.json", JsonConvert.SerializeObject(Purchases.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Repayments.json", JsonConvert.SerializeObject(Repayments.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Sales.json", JsonConvert.SerializeObject(Sales.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"SavedPurchases.json", JsonConvert.SerializeObject(SavedPurchases.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"SavedSales.json", JsonConvert.SerializeObject(SavedSales.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Shops.json", JsonConvert.SerializeObject(Shops.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Suppliers.json", JsonConvert.SerializeObject(Suppliers.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Transactions.json", JsonConvert.SerializeObject(Transactions.ToArray(), Formatting.Indented));
            //System.IO.File.WriteAllText(path + @"Users.json", JsonConvert.SerializeObject(Users.ToArray(), Formatting.Indented));

        }

    }
}