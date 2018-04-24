using System;
using System.Diagnostics;
using System.Windows.Forms;
using ShopLibrary;
using ShopLibrary.Models;
using WinFormsUI.Forms;
using WinFormsUI.Resources.Languages;
using System.Globalization;
using ExcelImporter;
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

                Culture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);
            }
            catch (Exception e)
            {
                MessageBox.Show(ResourceManager.GetString("ErrorConnectingToDatabaseServer", Culture) +
                                e.Message, 
                                ResourceManager.GetString("Error", Culture));
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
                    MessageBox.Show(e.Message, en.Error);
                }

                Form login = new LoginForm();
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK)
                {
                    Form form = new DashboardForm();
                    result = form.ShowDialog();
                    //Application.Run(new ImportForm());
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