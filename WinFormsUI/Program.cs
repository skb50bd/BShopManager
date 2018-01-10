﻿using System;
using System.Diagnostics;
using System.Windows.Forms;
using ShopLibrary;
using ShopLibrary.Models;
using WinFormsUI.Forms;
using static ShopLibrary.GlobalConfig;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]

namespace WinFormsUI
{
    internal static class Program
    {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>

        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the Database Connections
            try
            {
                InitializeConnections(false, true, false);
                LoadBasicDatabase();
            }
            catch (Exception e)
            {
                MessageBox.Show("Could not connect to server\n" +
                                e.Message, "Error");
            }
            finally
            {
                Debug.WriteLine(
                    $"User count         {Users.Count}\n" +
                    $"Shop count         {Shops.Count}\n" +
                    $"Bank Account count {BankAccounts.Count}\n" +
                    $"Employees count    {Employees.Count}\n" +
                    $"Customers count    {Customers.Count}\n" +
                    $"Suppliers count    {Suppliers.Count}\n" +
                    $"Products count     {Products.Count}");
            }

            //BackUpDatabase.ToJson(@"D:/ShopDb/");

            // START THE FORM
            //Application.Run(new HomeForm());
            while (true)
            {
                try
                {
                    FormCollection forms = Application.OpenForms;
                    foreach (Form form in forms)
                        form.Close();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Error");
                }

                Form login = new LoginForm();
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Form form = new DashboardForm();
                    result = form.ShowDialog();
                    //Application.Run(new Import());
                    if (result != DialogResult.OK)
                    {
                        Connection[0].Logout();
                        break;
                    }
                }
                else if (result == DialogResult.Cancel)
                    break;
            }
            FormCollection forms2 = Application.OpenForms;
            foreach (Form form in forms2)
                form.Close();
        }
    }
}