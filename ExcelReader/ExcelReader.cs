﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using ShopLibrary.Models;

namespace ExcelImporter {
    public static class Import {
        #region Excel Reader
        // Cool shit.. just like database..
        static DataTable ReadExcelFile(string sheetName, string path) {
            using (var conn = new OleDbConnection()) {
                var dt = new DataTable();

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;ImportMixedTypes=Text;TypeGuessRows=0'";
                using (var comm = new OleDbCommand()) {
                    comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (var da = new OleDbDataAdapter()) {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }
        #endregion

        #region Customer
        public static List<Customer> ReadCustomer(string path) {
            var data = new List<string>();
            var Customers = new List<Customer>();
            var dt = ReadExcelFile("Customer", path);
            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray) {
                    data.Add(item.ToString());
                }
                var text = data[0];
                var texts = data[0].Split();
                var name = string.Empty;
                if (texts.Length > 0 && int.TryParse(texts[0], out var id))
                {
                    name = string.Empty;
                    for (var i = 1; i < texts.Length; i++)
                        name += texts[i] + " ";
                    name = name.Trim();
                }
                else
                {
                    name = text;
                }
                var a = new Customer {
                    FullName = name,
                    NickName = "",
                    CompanyName = data[1],
                    Address = data[2] + " " + data[7],
                    Phone = data[3],
                    Debt = 0,
                    IsActive = true,
                    Note = ""
                };

                Customers.Add(a);
                data.Clear();
            }
            return Customers;
        }
        public static void DisplayCustomers(List<Customer> Customers) {
            //Display Customers
            Console.WriteLine("Customers----------------------------------------------------------------------------------------");
            foreach (var i in Customers) {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    i.FullName,
                    i.CompanyName,
                    i.Address,
                    i.Phone
                );
            }
        }
        #endregion

        #region Product
        public static List<Product> ReadProduct(string path, Shop shop) {
            var data = new List<string>();
            var Products = new List<Product>();
            var dt = ReadExcelFile("Product", path);
            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray) {
                    data.Add(item.ToString());
                }
                var a = new Product {
                    ShopId = shop.ObjectId,
                    ProductName = data[0],
                    Category = data[1],
                    Specification = data[2],
                    Manufacturer = data[3],
                    ShopStock = (float)Convert.ToDouble(data[4]),
                    GodownStock = 0,
                    Units = new List<Unit>() { new Unit("pcs", 1) },
                    PurchasePrice = Convert.ToDecimal(data[5].Remove(0, 0)),
                    RetailPrice = Convert.ToDecimal(data[6].Remove(0, 0)),
                    AlertStock = (float)Convert.ToDouble(data[7]),
                    WholeSalePrice = Convert.ToDecimal(data[8].Remove(0, 0)),
                    Mrp = Convert.ToDecimal(data[9].Remove(0, 0)),
                    Notes = ""
                };
                Products.Add(a);
                data.Clear();
            }
            return Products;
        }
        public static void DisplayProducts(List<Product> Products) {
            //Display Products
            Console.WriteLine("Products----------------------------------------------------------------------------------------");
            foreach (var i in Products) {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}\t{9}\t{10}\t{11}",
                    i.GetShopId,
                    i.ProductId,
                    i.ProductName,
                    i.Category,
                    i.Specification,
                    i.Manufacturer,
                    i.ShopStock,
                    i.PurchasePrice,
                    i.RetailPrice,
                    i.AlertStock,
                    i.WholeSalePrice,
                    i.Mrp
                );
            }
        }
        #endregion

        #region Supplier
        public static List<Supplier> ReadSupplier(string path) {
            var data = new List<string>();
            var Suppliers = new List<Supplier>();
            var dt = ReadExcelFile("Supplier", path);
            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray) {
                    data.Add(item.ToString());
                }
                var a = new Supplier {
                    FullName = data[0],
                    NickName = "",
                    CompanyName = data[1],
                    Address = data[2] + " " + data[5],
                    Phone = data[3],
                    Payable = 0,
                    IsActive = true,
                    Note = ""
                };
                Suppliers.Add(a);
                data.Clear();
            }
            return Suppliers;
        }
        public static void DisplaySupplier(List<Supplier> Suppliers) {
            //Display Suppliers
            Console.WriteLine("Supplier----------------------------------------------------------------------------------------");
            foreach (var i in Suppliers) {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    i.FullName,
                    i.CompanyName,
                    i.Address,
                    i.Phone
                );
            }

        }
        #endregion
    }
}
