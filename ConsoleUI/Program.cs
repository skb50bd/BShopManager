using ShopLibrary.DataAccess;
using ShopLibrary.Models;
using ShopLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Threading;
using static ShopLibrary.GlobalConfig;
using static ConsoleUI.ReadDatabase;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Load dem database
            try
            {
                InitializeConnections(false, true, false);
                Console.WriteLine("Reading database...");
                LoadBasicDatabase();
            }
            catch (Exception)
            {
                Console.WriteLine("Error connecting to database");
                Console.WriteLine("The program will exit now");
            }
            #endregion

            #region Greeting and Authentication
            Console.WriteLine("Welcome to BShopConsole");
            Console.WriteLine("________________________");
            Console.WriteLine();
            Console.WriteLine("This UI is for developer's use");
            Console.Write("Login    : ");
            string user = Console.ReadLine();
            Console.Write("Password : ");
            string pwd = Console.ReadLine(); 
            #endregion

            if (Connection[0].Login(user, pwd)) // Successful Login
            {
                Console.WriteLine("The login was successful");
                Thread.Sleep(500);

                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("MAIN MENU");
                    Console.WriteLine("---------");
                    Console.WriteLine("1. Read database");
                    Console.WriteLine("2. Import excel data");
                    Console.WriteLine("3. Import ini data");
                    Console.WriteLine("0. Exit");

                    Console.Write("Enter your choice: ");
                    string line = Console.ReadLine();

                    if (line.ToLowerInvariant() == "exit" || line == "0")
                    {
                        Console.WriteLine("Exiting...");
                        Thread.Sleep(500);
                    }
                    else if (int.TryParse(line, out int choice))
                    {
                        ChooseMenu(choice);
                    }
                    else
                    {
                        Console.Error.WriteLine("Invalid Input.\n" +
                                                "Try Again");
                        Thread.Sleep(500);

                    }
                }
            }
            else if (Users.Exists(u => u.UserName == user)) 
                Console.WriteLine("Incorrect password");
            else
                Console.WriteLine("Invalid user");

        }

        static void ChooseMenu(int choice)
        {
            switch (choice)
            {
                case 1:
                    ReadCustomers();
                    ReadSuppliers();
                    ReadProducts();
                    break;

                case 2:
                    Console.WriteLine("Not implemented");
                    break;

                case 3:
                    while (true)
                    {
                        Console.Clear();
                        Console.WriteLine("MENU");
                        Console.WriteLine("-------------------");
                        Console.WriteLine("1. Sale Records");
                        Console.WriteLine("2. Purchase Records");
                        Console.WriteLine("0. Exit");
                        Console.Write("Enter your choice : ");
                        string line = Console.ReadLine();
                        if (line.ToLowerInvariant() == "exit" || line == "0")
                        {
                            Console.WriteLine("Exiting...");
                            Thread.Sleep(500);
                            return;
                        }

                        if (int.TryParse(line, out int choice2))
                        {
                            ImportIni.Choice(choice2);
                        }
                        else
                        {
                            Console.Error.WriteLine("Invalid Input.\n" +
                                                    "Try Again");
                            Thread.Sleep(500);
                        }
                    }
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
    }
}
