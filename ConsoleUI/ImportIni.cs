using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using IniParser;
using IniParser.Model;
using MongoDB.Bson;
using ShopLibrary.Models;
using static ShopLibrary.GlobalConfig;

namespace ConsoleUI {
    public class ImportIni
    {
        static Customer customer = new Customer();
        static List<ShoppingCart> cart = new List<ShoppingCart>();
        static List<Customer> customers;
        static ShoppingCart tCartItem = new ShoppingCart();
        static Sale sale = new Sale();
        static string folderPath;
        static string pref = string.Empty;


        public static void Choice(int choice)
        {
            switch (choice) {
                case 1:
                    ImportSaleRecords();
                    break;

                case 2:
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    Thread.Sleep(500);
                    break;

            }
        }

        private static string GetFolderPath()
        {
            Console.Write("Please enter the folder path containing .ini sale records: ");
            string path = Console.ReadLine();

            if (!Directory.Exists(path)) {
                Console.Error.WriteLine("Given path is not a folder/directory");
                return String.Empty;
            }
            return path;
        }

        private static string GetFilePath()
        {
            Console.Write("Please enter the full .ini file path: ");
            string path = Console.ReadLine();

            if (!File.Exists(path)) {
                Console.Error.WriteLine("File not found in the given path");
                return String.Empty;
            }
            return path;
        }

        private static void ImportSaleRecords()
        {

            // Getting the location of the records
            Console.WriteLine("Import Sale Records");
            folderPath = GetFolderPath();

            // Getting the files from the directory, and count
            string[] files = Directory.GetFiles(folderPath);
            Console.WriteLine($"Found {files.Length} files");

            FileIniDataParser parser = new FileIniDataParser();
            IniData data;

            int err    = 0, 
                succ   = 0, 
                rej    = 0;

            for (int i = 0; i < files.Length; i++) {
                pref   = "[ File : " +
                       i.ToString().PadLeft(4) +
                       " of " +
                       files.Length.ToString().PadLeft(4) +
                       "] ";

                Console.WriteLine(pref + $" {files[i]}");

                if (files[i].Contains(".ini")) {
                    try {
                        data = parser.ReadFile(files[i]);
                        Console.WriteLine($"Found {data.Sections.Count} Sections");

                        decimal d = 0;
                        if (decimal.TryParse(data["Gdata"]["Dscnt"], out decimal x))
                            d += x;
                        if (decimal.TryParse(data["Gdata"]["Less"], out x))
                            d += x;

                        customers = Customers.Where(c =>
                                c.FullName.ToLowerInvariant() == data["Gdata"]["Nknm"].ToLowerInvariant())
                            .ToList();
                        if (customers.Count == 0) {
                            Console.WriteLine($"Customer match not found: {data["Gdata"]["Nknm"]}");
                            Console.Write("Continue anyway? (Yes/no/retry): ");
                            string command = Console.ReadLine().ToLowerInvariant();

                            if (command == "no" || command == "n") {
                                File.Move(files[i],
                                    folderPath + @"\UnmatchedCustomers\" + Path.GetFileName(files[i]));
                                err++;
                                continue;
                            }
                            else if (command == "yes" || command == "y" || command == "") {
                                Console.WriteLine($"Continuing with temporary customer: {data["Gdata"]["Nknm"]}");
                            }
                            else if (command == "retry" || command == "r") {
                                data = parser.ReadFile(files[i]);
                                i--;
                                continue;
                            }
                            else {
                                Console.WriteLine("Invalid input");
                                i--;
                                continue;
                            }
                        }
                        if (customers.Count == 1) {
                            Console.WriteLine($"Exact customer match found: {customers[0].CustomerId}");
                            customer = customers[0];
                        }
                        else if (customers.Count > 1) {
                            Console.WriteLine("Multiple match found");
                            foreach (Customer c in customers) {
                                Console.WriteLine($"ID: {c.CustomerId} Name: {c.FullName}");
                            }
                            err++;
                            continue; ;
                        }

                        cart.Clear();
                        if (data.Sections.Count > 1) {
                            for (int j = 1; j < data.Sections.Count; j++) {
                                if (Products.Count(p => p.ProductName == data["Item" + j]["Des"] &&
                                                        p.Manufacturer == data["Item" + j]["Manu"]) == 1) {
                                    Product product = Products.Single(p =>
                                        p.ProductName == data["Item" + j]["Des"] &&
                                        p.Manufacturer == data["Item" + j]["Manu"]);
                                    tCartItem = new ShoppingCart {
                                        ProductId = product.ObjectId,
                                        ProductName = product.ProductName,
                                        Quantity = float.Parse(data["Item" + j]["Qnt"]),
                                        Unit = product.Units[0],
                                        UnitPrice = decimal.Parse(data["Item" + j]["Tpr"]) / decimal.Parse(data["Item" + j]["Qnt"]),
                                        UnitPurchasePrice = decimal.Parse(data["Item" + j]["Bpr"])
                                    };
                                    cart.Add(tCartItem);
                                }
                                else {
                                    Console.Write($"Product {data["Item" + j]["Des"]} is not in database. Continue anyway? (Yes/no/retry): ");
                                    string command = Console.ReadLine().ToLowerInvariant();

                                    if (command == "no" || command == "n") {
                                        File.Move(files[i],
                                            folderPath + @"\UnmatchedProducts\" + Path.GetFileName(files[i]));
                                        err++;
                                        break;
                                    }
                                    else if (command == "yes" || command == "y" || command == "") {
                                        Console.WriteLine($"Continuing with temporary product: {data["Item" + j]["Des"]}");
                                        tCartItem = new ShoppingCart {
                                            ProductId = ObjectId.Empty,
                                            ProductName = data["Item" + j]["Des"],
                                            Quantity = float.Parse(data["Item" + j]["Qnt"]),
                                            Unit = new Unit("pcs", 1),
                                            UnitPrice = decimal.Parse(data["Item" + j]["Tpr"]) / decimal.Parse(data["Item" + j]["Qnt"]),
                                            UnitPurchasePrice = decimal.Parse(data["Item" + j]["Bpr"])
                                        };
                                        cart.Add(tCartItem);
                                    }
                                    else if (command == "retry" || command == "r") {
                                        data = parser.ReadFile(files[i]);
                                        i--;
                                    }
                                    else {
                                        Console.WriteLine("Invalid input");
                                        i--;
                                    }
                                }
                            }
                        }

                        if (data["Gdata"]["Ttl"] == null) {
                            Console.WriteLine("Total Amount Not Found");
                            File.Move(files[i], folderPath + @"\NoProducts\" + Path.GetFileName(files[i]));
                            err++;
                        }
                        else {
                            Console.Clear();
                            sale = new Sale {
                                ObjectId = ObjectId.Empty,
                                ShopId = Shops[0].ObjectId,
                                SaleType = data["Gdata"]["Ctyp"] == "R"
                                    ? SaleType.RetailSale
                                    : SaleType.WholeSale,
                                CustomerId = customer.ObjectId,
                                CustomerName = data["Gdata"]["Nknm"],
                                CustomerCompany = data["Gdata"]["Flnm"],
                                CustomerAddress = data["Gdata"]["Adrs"],
                                TotalAmount = decimal.Parse(data["Gdata"]["Ttl"]),
                                Less = d,
                                Paid = decimal.Parse(data["Gdata"]["Paid"]),
                                DealTime = DateTime.ParseExact(data["Gdata"]["Date"], "dd/MM/yyyy",
                                    Culture.DateTimeFormat),
                                Note = String.Empty,
                                Meta = new Metadata {
                                    Created = DateTime.ParseExact(data["Gdata"]["Date"], "dd/MM/yyyy",
                                        Culture.DateTimeFormat),
                                    Creator = "OLD Software",
                                    Modified = DateTime.Now,
                                    Modifier = "brotal"
                                },
                                Cart = cart
                            };

                            #region Display Sale Info
                            Console.WriteLine($"Sale Id             : {sale.SaleId}");
                            Console.WriteLine($"Shop Id             : {sale.GetShopId}");
                            Console.WriteLine($"Sale Type           : {sale.SaleType}");
                            Console.WriteLine($"Customer Id         : {sale.GetCustomerId}");
                            Console.WriteLine($"Customer Name       : {sale.CustomerName}");
                            Console.WriteLine($"Customer Company    : {sale.CustomerCompany}");
                            Console.WriteLine($"Customer Address    : {sale.CustomerAddress}");
                            Console.WriteLine($"Total Amount        : {sale.GetTotalAmount} Tk");
                            Console.WriteLine($"Discount            : {sale.GetDiscount}%");
                            Console.WriteLine($"Less                : {sale.GetLess} Tk");
                            Console.WriteLine($"Paid                : {sale.GetPaid} Tk");
                            Console.WriteLine($"Due                 : {sale.GetDue} Tk");
                            Console.WriteLine($"Time                : {sale.DealTime.ToString("F")}");
                            Console.WriteLine($"Cart Items          : {sale.Cart.Count}");
                            foreach (ShoppingCart cartItem in sale.Cart) {
                                Console.WriteLine("\tPID: " + $"{cartItem.GetProductId} " +
                                                  $" {cartItem.ProductName}".PadRight(20) +
                                                  $" {cartItem.Quantity}");
                            }
                            #endregion

                            Console.WriteLine();
                            Console.Write("Import to database? (Y/n): ");
                            string line = Console.ReadLine().ToLowerInvariant();
                            if (line == "" || line == "yes" || line == "y") {
                                // Todo - Import to database
                                Connection[0].InsertOldSale(sale);
                                File.Move(files[i], folderPath + @"\done\" + Path.GetFileName(files[i]));
                                succ++;
                                Console.Clear();
                            }
                            else
                            {
                                Console.WriteLine("Rejected");
                                rej++;
                            }
                        }
                    }
                    catch {
                        Console.WriteLine("Invalid data - " + files[i]);
                        err++;
                    }
                }
                else {
                    Console.WriteLine("Invalid file");
                    err++;
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine($"TOTAL FILES          : {files.Length}");
            Console.WriteLine($"IMPORTED             : {succ}");
            Console.WriteLine($"REJECTED             : {rej}");
            Console.WriteLine($"ERROR / INVALID FILE : {err}");
            Thread.Sleep(2000);
            Console.ReadKey();
        }
    }
}
