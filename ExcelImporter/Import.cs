using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.OleDb;
using ShopLibrary.Models;
using ShopLibrary.DataAccess;

namespace ExcelImporter {
    class Import {
        static void Main(string[] args) {
            List<Product> items = new List<Product>();
            List<Customer> Customer = new List<Customer>();
            List<Supplier> Supp = new List<Supplier>();

            List<string> data = new List<string>();
            //items = setValue();

            //write the spreadsheet name in ReadExcelFile()


            DataTable dt = ReadExcelFile("Product");

            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray)
                    data.Add(item.ToString());
                Product a = new Product();
                a.ShopId =
                    a.ObjectId = MongoConnector.GetNextObjectId("Product"),
                a.ProductName = data[0];
                a.Category = data[1];
                a.Specification = data[2];
                a.Manufacturer = data[3];
                a.ShopStock = (float)Convert.ToDouble(data[4]);
                a.PurchasePrice = Convert.ToDecimal(data[5].Remove(0, 0));
                a.RetailPrice = Convert.ToDecimal(data[6].Remove(0, 0)); ;
                a.AlertStock = (float)Convert.ToDouble(data[7]);
                a.WholeSalePrice = Convert.ToDecimal(data[8].Remove(0, 0));
                a.Mrp = Convert.ToDecimal(data[9].Remove(0, 0));
                items.Add(a);
                data.Clear();
            }

            dt.Clear();
            dt = ReadExcelFile("Supplier");
            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray) {
                    data.Add(item.ToString());
                }
                Supplier a = new Supplier();
                a.FullName = data[0];
                a.CompanyName = data[1];
                a.Address = data[2] + " " + data[5];
                a.Phone = data[3];
                Supp.Add(a);
                data.Clear();
            }

            dt.Clear();
            dt = ReadExcelFile("Customer");
            foreach (DataRow dataRow in dt.Rows) {
                foreach (var item in dataRow.ItemArray) {
                    data.Add(item.ToString());
                }
                Customer a = new Customer();
                a.FullName = data[0];
                a.CompanyName = data[1];
                a.Address = data[2] + " " + data[7];
                a.Phone = data[3];
                Customer.Add(a);
                data.Clear();
            }

            //Display Products
            Console.WriteLine("Products----------------------------------------------------------------------------------------");
            foreach (Product i in items) {
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


            //Display Customers
            Console.WriteLine("Customers----------------------------------------------------------------------------------------");
            foreach (Customer i in Customer) {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    i.FullName,
                    i.CompanyName,
                    i.Address,
                    i.Phone
                    );
            }


            //Display Suppliers
            Console.WriteLine("Supplier----------------------------------------------------------------------------------------");
            foreach (Supplier i in Supp) {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}",
                    i.FullName,
                    i.CompanyName,
                    i.Address,
                    i.Phone
                    );
            }

            Console.Read();
        }

        // Cool shit.. just like database..
        static DataTable ReadExcelFile(string sheetName) {

            using (OleDbConnection conn = new OleDbConnection()) {
                DataTable dt = new DataTable();

                conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Desktop\RovelRefregeration.xlsx" + ";" + "Extended Properties='Excel 12.0 Xml;HDR=YES;ImportMixedTypes=Text;TypeGuessRows=0'";
                using (OleDbCommand comm = new OleDbCommand()) {
                    comm.CommandText = "Select * from [" + sheetName + "$]";

                    comm.Connection = conn;

                    using (OleDbDataAdapter da = new OleDbDataAdapter()) {
                        da.SelectCommand = comm;
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }



    }
}
