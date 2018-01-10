using ShopLibrary.DataAccess;
using ShopLibrary.Models;
using ShopLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using static ShopLibrary.GlobalConfig;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InitializeConnections(false, true, false);
                LoadBasicDatabase();
            }
            catch (Exception)
            {
                Console.WriteLine("Error connecting to database");
                Console.WriteLine("The program will exit now");
            }

            string command = String.Empty;

            Console.WriteLine("Welcome to BShop Manager");
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("This UI is for troubleshooting purposes");
            Console.Write("Login : ");
            string user = Console.ReadLine();
            Console.Write("Password : ");
            string pwd = Console.ReadLine();

            if (Connection[0].Login(user, pwd))
            {
                Console.WriteLine("The login was successful");
                Console.Clear();
                Console.WriteLine("Counting items in database...");
                Console.WriteLine();

                #region Customer
                Console.WriteLine($"Customers : \t{Customers.Count}." +
                                          $"\n\tTotal Due : \t{Customers.Sum(c => c.Debt).ToString("0.##") + " Tk"} ({Customers.Count(c => c.Debt > 0)})");
                Console.Write("Show List? (y/N) : ");
                command = Console.ReadLine();
                if (command.ToLower() == "y")
                {
                    Console.WriteLine("ID".PadLeft(6) + " " +
                        "Name".PadRight(35) + " " +
                        "Phone".PadLeft(15) + " " +
                        "Due".PadLeft(10));
                    foreach (Customer customer in Customers)
                    {
                        Console.WriteLine(customer.CustomerId.PadLeft(6) + " " +
                                          customer.FullName.PadRight(35) + " " +
                                          customer.Phone.PadLeft(15) + " " +
                                          customer.GetDebt.PadLeft(10));
                    }
                }
                Console.WriteLine("\n\n");
                #endregion
                #region Supplier
                Console.WriteLine($"Suppliers : \t{Suppliers.Count}." +
                                          $"\n\tTotal Payable: \t{Suppliers.Sum(s => s.Payable).ToString("0.##") + " Tk"} ({Suppliers.Count(s => s.Payable > 0)})");
                Console.Write("Show List? (y/N) : ");
                command = Console.ReadLine();
                if (command.ToLower() == "y")
                {
                    Console.WriteLine("ID".PadLeft(6) + " " +
                                      "Name".PadRight(35) + " " +
                                      "Phone".PadLeft(15) + " " +
                                      "Payable".PadLeft(10));
                    foreach (Supplier supplier in Suppliers)
                    {
                        Console.WriteLine(supplier.SupplierId.PadLeft(6) + " " +
                                          supplier.FullName.PadRight(35) + " " +
                                          supplier.Phone.PadLeft(15) + " " +
                                          supplier.GetPayable.PadLeft(10));
                    }
                }
                Console.WriteLine("\n\n");
                #endregion
                #region Product
                Console.WriteLine($"Products : \t{Products.Count}" +
                                          $"\n\tLow Stock : \t{Products.Count(c => c.StockIsLow && c.TotalStock > 0)}" +
                                          $"\n\tEmpty Stock : \t{Products.Count(c => c.TotalStock == 0.0)}" +
                                          $"\n\tPurchase Worth : \t{Products.Sum(p => p.PurchasePrice * (decimal)p.TotalStock).ToString("0.##")}");
                Console.Write("Show List? (y/N) : ");
                command = Console.ReadLine();
                if (command.ToLower() == "y")
                {
                    Console.WriteLine("ID".PadLeft(6) + " " +
                                      "Name".PadRight(35) + " " +
                                      "Stock".PadLeft(15) + " " +
                                      "Prc. Price".PadRight(10) + " " +
                                      "Ret Price".PadRight(10));
                    foreach (Product product in Products)
                    {
                        Console.WriteLine(product.ProductId.PadLeft(6) + " " +
                                          product.ProductName.PadRight(35) + " " +
                                          $"{product.GetTotalStock} {product.GetDefaultUnitName}".PadLeft(15) + " " +
                                          $"{product.GetPurchasePrice} Tk".PadRight(10) + " " +
                                          $"{product.GetRetailPrice} Tk".PadRight(10));
                    }
                }
                Console.WriteLine("\n\n"); 
                #endregion
                Console.WriteLine("Press enter to quit");
                Console.ReadLine();
            }
            else if (Users.Exists(u => u.UserName == user))
                Console.WriteLine("Incorrect Password");
            else
                Console.WriteLine("Invalid User");

        }
    }
}
