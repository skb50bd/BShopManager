using ShopLibrary.DataAccess;
using ShopLibrary.Models;
using ShopLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            GlobalConfig.InitializeConnections(false, true, false);
            List<User> Users = GlobalConfig.Connection[0].GetUserAll();
            Console.WriteLine(Users.Count);
        }
    }
}
