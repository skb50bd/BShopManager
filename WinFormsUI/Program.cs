using System;
using System.Diagnostics;
using System.Windows.Forms;
using ShopLibrary.Models;
using WinFormsUI.Forms;
//using WinFormsUI.Resources.Languages;
using System.Globalization;
using static ShopLibrary.GlobalConfig;
using System.Configuration;
using Resources.Languages;

namespace WinFormsUI {
    internal static class Program {
        /// <summary>
        ///     The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main () {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //Initialize the Database Connections
            try {
                InitializeConnections(false, true, false);
                LoadBasicDatabase();

                Culture = CultureInfo.CreateSpecificCulture(Properties.Settings.Default.Language);
            }
            catch (Exception) {
                //MessageBox.Show(ResourceManager.GetString("ErrorConnectingToDatabaseServer", Culture) +
                //e.Message, 
                //ResourceManager.GetString("Error", Culture));
                MessageBox.Show("Couldn't Connect to Server");
            }
            finally {
                Debug.WriteLine(
                                $"User count         {Users.Count}\n"
                              + $"Shop count         {Shops.Count}\n"
                              + $"Bank Account count {BankAccounts.Count}\n"
                              + $"Employees count    {Employees.Count}\n"
                              + $"Customers count    {Customers.Count}\n"
                              + $"Suppliers count    {Suppliers.Count}\n"
                              + $"Products count     {Products.Count}");
            }

            //BackUpDatabase.ToJson(@"D:/ShopDb/");

            // START THE FORM
            //Application.Run(new HomeForm());
            while (true) {
                try {
                    FormCollection forms = Application.OpenForms;
                    foreach (Form form in forms)
                        form.Close();
                }
                catch (Exception e) {
                    MessageBox.Show(e.Message, en.Error);
                }

                Form         login  = new LoginForm();
                DialogResult result = login.ShowDialog();

                if (result == DialogResult.OK) {
                #region Payroll Checking
                    BulkPayment b = new BulkPayment();
                    b = Connection[0].LatestPay();

                    if (CurrentUser.AccessLevel <= ShopLibrary.Models.UserRole.Admin) {
                        if (b == null || b.Meta.Created.Month != DateTime.Today.Month) {
                            DialogResult res;
                            if(ConfigurationManager.AppSettings["Language"] == "bn-BD")
                            {
                                res = MessageBox
                                .Show("এই মাস এর বেতনসমূহ পরিশোধ হয় নাই \nআপনি কি এখন পরিশোধ করতে চান ?",
                                      "অনুমোদন",
                                      MessageBoxButtons.YesNo);
                            }
                            else
                                 res= MessageBox
                                    .Show("This month's Payment has not been given\n Do you want to Distribute Payment now?",
                                          "Confirmation",
                                          MessageBoxButtons.YesNo);

                            if (res == DialogResult.Yes) {
                                BulkPayment model = new BulkPayment {
                                    Meta = new Metadata {
                                        Creator = CurrentUser.UserName
                                    }
                                };

                                if (Connection[0].Payall(model)) {
                                    if (ConfigurationManager.AppSettings["Language"] == "bn-BD")
                                        MessageBox.Show("কাজ সুষ্ঠভাবে সম্পন্ন হয়েছে!");
                                    else
                                        MessageBox.Show("Operation Successful!");
                                }
                            }
                        }
                    }
                    #endregion

                    Form form = new DashboardForm();
                    result = form.ShowDialog();

                

                    //Application.Run(new ImportForm());
                    if (result != DialogResult.OK) {
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
