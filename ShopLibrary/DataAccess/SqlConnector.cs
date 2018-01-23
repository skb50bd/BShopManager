using System;
using System.Collections.Generic;
using ShopLibrary.Models;


namespace ShopLibrary.DataAccess {
    public class SqlConnector : IDataConnection {
        /// <summary>
        ///     Authenticates User and Returns It's User ID
        /// </summary>
        /// <param name="userName">The Login User Name</param>
        /// <param name="password">Correponding Password for the UserName</param>
        /// <returns></returns>
        public bool Login(string userName, string password) =>
        //int? userId = 0;
        //using (var connection = new SqlConnection(CnnString(Db))) {
        //     Connecting With Dapper
        //    var p = new DynamicParameters();
        //    p.Add("@LoginName", userName);
        //    p.Add("@Passphrase", password);
        //    p.Add("@userId", 0, DbType.Int32, ParameterDirection.Output);
        //    p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //    connection.Execute("dbo.spLogin", p, commandType: CommandType.StoredProcedure);
        //    if (p.Get<string>("@responseMessage") == "Success") {
        //        userId = p.Get<int?>("@userId");
        //        return true;
        //    }
        //    return false;
        //}
        true;


        //public List<User> GetUserAll() {
        //    //List<User> output;
        //    //using (IDbConnection connection =
        //    //    new SqlConnection(CnnString(Db))) {
        //    //    output = connection.Query<User>("dbo.spGetUserAll").ToList();
        //    //}
        //    //return output;
        //}

        //public List<string> GetUserNameAll() {
        //    //List<string> output;
        //    //using (IDbConnection connection =
        //    //    new SqlConnection(CnnString(Db))) {
        //    //    output = connection.Query<string>("dbo.spGetUserNameAll").ToList();
        //    //}
        //    //return output;
        //}

        //public User GetUserById(int id) {
        //    //var u = new User();
        //    //using (IDbConnection connection =
        //    //    new SqlConnection(CnnString(Db))) {
        //    //    var p = new DynamicParameters();
        //    //    p.Add("@userId", id);

        //    //    u = connection.Query<User>("dbo.spGetUserById", p, commandType: CommandType.StoredProcedure)
        //    //        .SingleOrDefault();
        //    //}
        //    //return u;
        //}

        public User InsertUser(User model) => throw new NotImplementedException();

        public bool UpdateUser(User u) => throw new NotImplementedException();

        public bool UpdateUserWithoutPassword(User u) => throw new NotImplementedException();

        //public Standard InsertUser(Standard model, string password) {
        //    //u.Id = 0;

        //    //using (IDbConnection connection =
        //    //    new SqlConnection(CnnString(Db))) {
        //    //    // Connecting With Dapper
        //    //    var p = new DynamicParameters();
        //    //    p.Add("@FullName", model.FullName);
        //    //    p.Add("@NickName", model.NickName);
        //    //    p.Add("@UserName", model.UserName);
        //    //    p.Add("@AccessLevel", model.AccessLevel);
        //    //    p.Add("@Address", model.Address);
        //    //    p.Add("@ContactNumber", model.Phone);
        //    //    p.Add("@EmailAddress", model.EmailAddress);
        //    //    p.Add("@Password", password);
        //    //    p.Add("@uid", 0, DbType.Int32, ParameterDirection.Output);
        //    //    p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //    //    connection.Execute("dbo.spInsertUser", p, commandType: CommandType.StoredProcedure);
        //    //    //u.Id = p.Get<int?>("@uid") == null ? 0 : p.Get<int>("@uid");
        //    //}
        //    //return model;
        //}

        public bool UpdateUser(User u, string password) =>
            //using (IDbConnection connection =
            //    new SqlConnection(CnnString(Db))) {
            //    // Connecting With Dapper
            //    var p = new DynamicParameters();
            //    p.Add("@FullName", u.FullName);
            //    p.Add("@NickName", u.NickName);
            //    p.Add("@UserName", u.UserName);
            //    p.Add("@AccessLevel", u.AccessLevel);
            //    p.Add("@Address", u.Address);
            //    p.Add("@ContactNumber", u.Phone);
            //    p.Add("@EmailAddress", u.EmailAddress);
            //    p.Add("@Password", password);
            //    p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

            //    connection.Execute("dbo.spUpdateUser", p, commandType: CommandType.StoredProcedure);
            //    if (p.Get<string>("@responseMessage") == "Success")

            //        MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
            //}
            false;

        public bool DeleteUserByUserName(string userName) => throw new NotImplementedException();

        public bool DisableUserByUserName(string userName) => throw new NotImplementedException();

        public BankAccount InsertBankAccount(BankAccount model) => throw new NotImplementedException();

        public bool DeleteBankAccount(BankAccount model) => throw new NotImplementedException();

        public bool UpdateBankAccount(BankAccount model) => throw new NotImplementedException();

        public List<Transaction> GetTransactionsAll() => throw new NotImplementedException();

        public List<BankAccount> GetBankAccountsAll() => throw new NotImplementedException();

        public Transaction InsertTransaction(Transaction model) => throw new NotImplementedException();

        public bool DeleteTransaction(Transaction model) => throw new NotImplementedException();

        public Shop InsertShop(Shop model) => throw new NotImplementedException();

        public List<Shop> GetShopsAll() => throw new NotImplementedException();

        public bool UpdateShop(Shop model) => throw new NotImplementedException();

        public bool DeleteShop(Shop model) => throw new NotImplementedException();

        public bool DeleteUser(int id) =>
            //using (IDbConnection connection =
            //    new SqlConnection(CnnString(Db))) {
            //    // Connecting With Dapper
            //    var p = new DynamicParameters();
            //    p.Add("@uid", id);
            //    p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

            //    connection.Execute("dbo.spDeleteUserById", p, commandType: CommandType.StoredProcedure);
            //    if (p.Get<string>("@responseMessage") == "Success")
            //        return true;
            //    MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
            //}
            false;

        public Customer InsertCustomer(Customer model) => throw new NotImplementedException();
        public List<Customer> GetCustomersAll() => throw new NotImplementedException();
        public bool UpdateCustomer(Customer model) => throw new NotImplementedException();
        public bool DeleteCustomer(Customer model) => throw new NotImplementedException();
        public DebtCollection CollectDue(DebtCollection due) => throw new NotImplementedException();
        public List<DebtCollection> GetDueCollectionAll() => throw new NotImplementedException();
        public bool DeleteCollectedDue(DebtCollection due) => throw new NotImplementedException();
        public bool DeletePayment(Payment model) => throw new NotImplementedException();

        public Category InsertCategory(Category model) => throw new NotImplementedException();

        public bool DeleteCategory(Category model) => throw new NotImplementedException();

        public bool UpdateCategory(Category model) => throw new NotImplementedException();

        public List<Category> GetCategoryAll() => throw new NotImplementedException();

        public Product InsertProduct(Product model) => throw new NotImplementedException();

        public List<Product> GetProductsAll() => throw new NotImplementedException();

        public bool UpdateProduct(Product model) => throw new NotImplementedException();

        public bool DeleteProduct(Product model) => throw new NotImplementedException();

        public bool DisableCustomer(Customer model) => throw new NotImplementedException();
        public DebtCollection CollectDebt(DebtCollection due) => throw new NotImplementedException();
        public List<DebtCollection> GetDebtCollectionAll() => throw new NotImplementedException();
        public bool DeleteDebtCollection(DebtCollection due) => throw new NotImplementedException();
        public Supplier InsertSupplier(Supplier model) => throw new NotImplementedException();
        public List<Supplier> GetSupplierAll() => throw new NotImplementedException();
        public bool UpdateSupplier(Supplier model) => throw new NotImplementedException();
        public bool DeleteSupplier(Supplier model) => throw new NotImplementedException();
        public bool DisableSupplier(Supplier model) => throw new NotImplementedException();
        public Repayment Repay(Repayment model) => throw new NotImplementedException();
        public List<Repayment> GetRepaymentAll() => throw new NotImplementedException();
        public bool DeleteRepayment(Repayment model) => throw new NotImplementedException();
        public Employee InsertEmployee(Employee model) => throw new NotImplementedException();

        public List<Employee> GetEmployeeAll() => throw new NotImplementedException();

        public bool UpdateEmployee(Employee model) => throw new NotImplementedException();

        public bool DeleteEmployee(Employee model) => throw new NotImplementedException();

        public bool DisableEmployee(Employee model) => throw new NotImplementedException();

        public Payment Pay(Payment model) => throw new NotImplementedException();

        public List<Payment> GetPaymentAll() => throw new NotImplementedException();

        public Sale InsertSale(Sale model) => throw new NotImplementedException();
        public Sale SaveSale(Sale model) => throw new NotImplementedException();

        public bool DeleteSale(Sale model) => throw new NotImplementedException();
        public List<Sale> GetSaleByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Sale> GetSaleByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Sale> GetSaleByShop(Shop shop, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Sale> GetSaleAll() => throw new NotImplementedException();
        public bool DeleteSavedSale(Sale model) => throw new NotImplementedException();
        public List<Sale> GetSavedSaleAll() => throw new NotImplementedException();
        public Expense InsertExpense(Expense model) => throw new NotImplementedException();
        public List<Expense> GetExpeneAll() => throw new NotImplementedException();
        public List<Expense> GetExpenseByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public bool DeleteExpense(Expense model) => throw new NotImplementedException();
        public Purchase InsertPurchase(Purchase model) => throw new NotImplementedException();
        public List<Purchase> GetPurchaseAll() => throw new NotImplementedException();
        public List<Purchase> GetPurchaseByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Purchase> GetPurchaseBySupplier(Supplier supplier, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public bool DeletePurchase(Purchase model) => throw new NotImplementedException();
        public Purchase SavePurchase(Purchase model) => throw new NotImplementedException();
        public bool DeleteSavedPurchase(Purchase model) => throw new NotImplementedException();
        public List<Purchase> GetSavedPurchaseAll() => throw new NotImplementedException();
        public Refund InsertRefund(Refund model) => throw new NotImplementedException();
        public bool UpdateRefund(Refund model) => throw new NotImplementedException();
        public bool DeleteRefund(Refund model) => throw new NotImplementedException();
        public List<Refund> GetRefundAll() => throw new NotImplementedException();
        public List<Refund> GetRefundByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Refund> GetRefundBySale(Sale sale) => throw new NotImplementedException();
        public PurchaseReturn InsertPurchaseReturn(PurchaseReturn model) => throw new NotImplementedException();
        public bool UpdatePurchaseReturn(PurchaseReturn model) => throw new NotImplementedException();
        public bool DeletePurchaseReturn(PurchaseReturn model) => throw new NotImplementedException();
        public List<PurchaseReturn> GetPurchaseReturnAll() => throw new NotImplementedException();
        public List<PurchaseReturn> GetPurchaseReturnByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<PurchaseReturn> GetPurchaseReturnByPurchase(Purchase sale) => throw new NotImplementedException();
        public List<PurchaseReturn> GetPurchaseReturnBySupplier(Supplier supplier, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public void Logout() => throw new NotImplementedException();
        public List<Transaction> GetTransactionsByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Transaction> GetTransactionsByBankAccount(BankAccount bankAccount, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<DebtCollection> GetDebtCollectionByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<DebtCollection> GetDebtCollectionByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Repayment> GetRepaymentBySupplier(Supplier supplier, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Repayment> GetRepaymentByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Payment> GetPaymentByEmployee(Employee employee, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Payment> GetPaymentByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();
        public List<Refund> GetRefundByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();
        public bool NewUserNameIsValid(string userName) => throw new NotImplementedException();
        public List<User> GetUserAll() => throw new NotImplementedException();
        public CashModification InsertCashModification(CashModification model) => throw new NotImplementedException();
        public List<CashModification> GetCashModificationAll() => throw new NotImplementedException();
        public bool DeleteCashModification(CashModification model) => throw new NotImplementedException();
        public Cash GetCurrentCash() => throw new NotImplementedException();
        public Sale InsertOldSale(Sale model) => throw new NotImplementedException();

        //        public BankAccount InsertBankAccount(BankAccount model) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@aName", model.BankAccountName);
        //                p.Add("@bName", model.BankName);
        //                p.Add("@aNumber", model.AccountNumber);
        //                p.Add("@cBalance", model.CurrentBalance);
        //                p.Add("@Creator", CurrentUser.Id);
        //                p.Add("@bid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertBankAccount", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@bid") == null ? 0 : p.Get<int>("@bid");
        //                //MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public bool DeleteBankAccount(BankAccount model) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@bid", model.Id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteBankAccountById", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public bool UpdateBankAccount(BankAccount model) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@aName", model.BankAccountName);
        //                p.Add("@bName", model.BankName);
        //                p.Add("aNumber", model.AccountNumber);
        //                p.Add("cBalance", model.CurrentBalance);
        //                p.Add("@Modifier", CurrentUser.Id);
        //                p.Add("@bid", model.Id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spUpdateBankAccount", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public List<BankAccount> GetBankAccountsAll() {
        //            List<BankAccount> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<BankAccount>("dbo.spGetBankAccountAll").ToList();
        //            }
        //            return output;
        //        }

        //        public List<Transaction> GetTransactionsAll() {
        //            List<Transaction> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Transaction>("dbo.spGetTransactionAll").ToList();
        //            }
        //            return output;
        //        }

        //        public Transaction InsertTransaction(Transaction model) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@baid", model.BankAccountId);
        //                p.Add("@type", model.TransactionType);
        //                p.Add("@amount", model.Amount);
        //                if (model.CustomerId == 0)
        //                    p.Add("@csId", null);
        //                else
        //                    p.Add("@csId", model.CustomerId);
        //                p.Add("@individual", model.Individual);
        //                p.Add("@tCode", model.TransactionCode);
        //                p.Add("@cNo", model.CheckNumber);
        //                p.Add("@note", model.Note);
        //                p.Add("@Creator", CurrentUser.Id);
        //                p.Add("@tid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertTransaction", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@tid") == null ? 0 : p.Get<int>("@tid");
        //                //MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public bool DeleteTransaction(int tid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@tid", tid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteTransaction", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Shop InsertShop(Shop model, int pid) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@name", model.Name);
        //                p.Add("@tag", model.Tagline);
        //                p.Add("@propietorId", pid);
        //                p.Add("addr", model.Address);
        //                p.Add("@details", model.Details);
        //                p.Add("@contNum", model.ContactNumbers);
        //                p.Add("@email", model.EmailAddresses);
        //                p.Add("@creator", CurrentUser.Id);
        //                p.Add("@sid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertShop", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@sid") == null ? 0 : p.Get<int>("@sid");
        //                //MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public List<Shop> GetShopsAll() {
        //            List<Shop> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Shop>("dbo.spGetShopAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool UpdateShop(Shop model, int pid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@name", model.Name);
        //                p.Add("@tag", model.Tagline);
        //                p.Add("@propietorId", pid);
        //                p.Add("addr", model.Address);
        //                p.Add("@details", model.Details);
        //                p.Add("@contNum", model.ContactNumbers);
        //                p.Add("@email", model.EmailAddresses);
        //                p.Add("@modifier", CurrentUser.Id);
        //                p.Add("@sid", model.Id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spUpdateShop", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public bool DeleteShop(int sid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@sid", sid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteShop", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Customer InsertCustomer(Customer model) {
        //            model.CustomerId = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@FullName", model.FullName);
        //                p.Add("@NickName", model.NickName);
        //                p.Add("@Address", model.Address);
        //                p.Add("@City", model.City);
        //                p.Add("@ContactNumber", model.Phone);
        //                p.Add("@EmailAddress", model.EmailAddress);
        //                p.Add("@Company", model.CompanyName);
        //                p.Add("@Due", model.Due);
        //                p.Add("@Creator", CurrentUser.Id);
        //                p.Add("@cid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertCustomer", p, commandType: CommandType.StoredProcedure);
        //                model.CustomerId = p.Get<int?>("@cid") == null ? 0 : p.Get<int>("@cid");
        //                //MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public List<Customer> GetCustomersAll() {
        //            List<Customer> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Customer>("dbo.spGetCustomerAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool UpdateCustomer(Customer model) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@FullName", model.FullName);
        //                p.Add("@NickName", model.NickName);
        //                p.Add("@Address", model.Address);
        //                p.Add("@City", model.City);
        //                p.Add("@ContactNumber", model.Phone);
        //                p.Add("@EmailAddress", model.EmailAddress);
        //                p.Add("@Company", model.CompanyName);
        //                p.Add("@Due", model.Due);
        //                p.Add("@Modifier", CurrentUser.Id);
        //                p.Add("@cid", model.CustomerId);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spUpdateCustomer", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public bool DeleteCustomer(int cid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@cid", cid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteCustomer", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public CollectedDue CollectDue(int cid, decimal amount) {
        //            var model = new CollectedDue {
        //                Id = 0,
        //                Amount = amount
        //            };
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@cid", cid);
        //                p.Add("@amount", amount);
        //                p.Add("@Creator", CurrentUser.Id);
        //                p.Add("@did", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spCollectDue", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@did") == null ? 0 : p.Get<int>("@did");
        //                //MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public List<CollectedDue> GetCollectedDueAll() {
        //            List<CollectedDue> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<CollectedDue>("dbo.spGetCollectedDueAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool DeleteCollectedDue(int did) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@did", did);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteCollectedDue", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public List<Record> GetCustomerRecordById(int cid) {
        //            List<Record> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Record>($"dbo.spGetCustomerRecordById @cid = {cid}").ToList();
        //            }
        //            return output;
        //        }

        //        public bool DeleteRecord(string type, int id) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@type", type);
        //                p.Add("@id", id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteRecord", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Product InsertProduct(Product model, int caid, int spid) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@sid", model.ShopId);
        //                p.Add("@pName", model.Name);
        //                p.Add("@file", model.FileAs);
        //                p.Add("@sShop", model.ShopStock);
        //                p.Add("@sGodown", model.GodownStock);
        //                p.Add("@aStock", model.AlertStock);
        //                p.Add("@pPrice", model.PurchasePrice);
        //                p.Add("@rPrice", model.RetailPrice);
        //                p.Add("@wPrice", model.WholeSalePrice);
        //                p.Add("@mrp", model.Mrp);
        //                p.Add("@caid", caid);
        //                p.Add("@spid", spid);
        //                p.Add("@note", model.Notes);
        //                p.Add("@creator", CurrentUser.Id);
        //                p.Add("@pid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertProduct", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@pid") == null ? 0 : p.Get<int>("@pid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public List<Product> GetProductsAll() {
        //            List<Product> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Product>("dbo.spGetProductAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool UpdateProduct(Product model, int caid, int spid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@sid", model.ShopId);
        //                p.Add("@pName", model.Name);
        //                p.Add("@file", model.FileAs);
        //                p.Add("@sShop", model.ShopStock);
        //                p.Add("@sGodown", model.GodownStock);
        //                p.Add("@aStock", model.AlertStock);
        //                p.Add("@pPrice", model.PurchasePrice);
        //                p.Add("@rPrice", model.RetailPrice);
        //                p.Add("@wPrice", model.WholeSalePrice);
        //                p.Add("@mrp", model.Mrp);
        //                p.Add("@caid", caid);
        //                p.Add("@spid", spid);
        //                p.Add("@note", model.Name);
        //                p.Add("@modifier", CurrentUser.Id);
        //                p.Add("@pid", model.Id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spUpdateProduct", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public bool DeleteProduct(int pid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@pid", pid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteProduct", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public bool AddProduct(Product model) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@sShop", model.ShopStock);
        //                p.Add("@sGodown", model.GodownStock);
        //                p.Add("@pPrice", model.PurchasePrice);
        //                p.Add("@modifier", CurrentUser.Id);
        //                p.Add("@pid", model.Id);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spAddProduct", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Category InsertCategory(Category model) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();

        //                p.Add("@name", model.Name);
        //                p.Add("@cid", 0, DbType.Int32, ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertCategory", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@cid") == null ? 0 : p.Get<int>("@cid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public bool DeleteCategory(int caid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@caid", caid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteCategory", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public List<Category> GetCategoryAll() {
        //            List<Category> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Category>("dbo.spGetCategoryAll").ToList();
        //            }
        //            return output;
        //        }

        //        public Specification InsertSpecification(Specification model, int cid) {
        //            model.Id = 0;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();

        //                p.Add("@cid", cid);
        //                p.Add("@sName", model.Name);
        //                p.Add("@spid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertSpecification", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@spid") == null ? 0 : p.Get<int>("@spid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));
        //            }
        //            return model;
        //        }

        //        public bool DeleteSpecification(int spid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@spid", spid);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteSpecification", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public List<Specification> GetSpecificationAll() {
        //            List<Specification> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Specification>("dbo.spGetSpecificationAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool CheckSale(Sale model) {
        //            foreach (var sc in model.Cart) {
        //                List<Product> product;
        //                using (IDbConnection connection =
        //                    new SqlConnection(CnnString(Db))) {
        //                    product = connection.Query<Product>("dbo.spGetProductById @pid = " + sc.ObjectId)
        //                        .ToList();
        //                }
        //                if (product.Count != 0) {
        //                    if (product[0].ShopStock + product[0].GodownStock < sc.Quantity) {
        //                        MessageBox.Show("Not Enough in Stock\n" +
        //                                        "Somehow, the product availability is lower than you want", "Error");
        //                        return false;
        //                    }
        //                } else {
        //                    MessageBox.Show("Product Not Fond in Database\n", "Error");
        //                    return false;
        //                }
        //            }
        //            return true;
        //        }

        //        public Sale InsertSale(Sale model) {
        //            model.Id = 0;
        //            model.Creator = CurrentUser.UserName;

        //            if (!CheckSale(model))
        //                return model;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();

        //                if (model.CustomerId == 0) p.Add("@cusid", null);
        //                else p.Add("cusid", model.CustomerId);
        //                p.Add("@iswSale", model.IsWholeSale ? 1 : 0);
        //                p.Add("@shopid", model.ShopId);
        //                p.Add("@total", model.Cart.Select(sc => sc.UnitPrice * (decimal)sc.Quantity).Sum());
        //                p.Add("@discountp", model.Discount);
        //                p.Add("@paid", model.Paid);
        //                p.Add("@less", model.Less);
        //                p.Add("@fitting", model.FittingBy);
        //                p.Add("@creator", CurrentUser.Id);
        //                p.Add("@sid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertSale", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@sid") == null ? 0 : p.Get<int>("@sid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));

        //                else
        //                    foreach (var sc in model.Cart) {
        //                        sc.Id = 0;
        //                        var p2 = new DynamicParameters();

        //                        p2.Add("@prid", sc.ObjectId);
        //                        p2.Add("@q", sc.Quantity);
        //                        p2.Add("@uprice", sc.UnitPrice);
        //                        p2.Add("@upprice", sc.UnitPurchasePrice);
        //                        p2.Add("@sid", model.Id);
        //                        p2.Add("@scid", 0, DbType.Int32, ParameterDirection.Output);
        //                        p2.Add("@responseMessage", "", DbType.String, size: 250,
        //                            direction: ParameterDirection.Output);

        //                        connection.Execute("dbo.spInsertShoppingCart", p2, commandType: CommandType.StoredProcedure);
        //                        sc.Id = p2.Get<int?>("@scid") == null ? 0 : p2.Get<int>("@scid");
        //                        if (sc.Id == 0)
        //                            MessageBox.Show(p.Get<string>("@responseMessage"));
        //                    }
        //            }
        //            return model;
        //        }

        //        public bool DeleteSale(int sid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@id", sid);
        //                p.Add("type", "Sale");
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteRecord", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Sale GetSaleById(int sid) {
        //            var s = new Sale();
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                var p = new DynamicParameters();
        //                p.Add("@sid", sid);

        //                s = connection.Query<Sale>("dbo.spGetSaleById", p, commandType: CommandType.StoredProcedure)
        //                    .SingleOrDefault();
        //                s.Cart = connection.Query<ShoppingCart>("dbo.spGetSaleShoppingCartById", p,
        //                    commandType: CommandType.StoredProcedure).ToList();
        //            }
        //            return s;
        //        }

        //        public List<Sale> GetSaleAll() {
        //            List<Sale> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Sale>("dbo.spGetSaleAll").ToList();
        //            }
        //            return output;
        //        }

        //        public Expense InsertExpense(Expense model) {
        //            model.Id = 0;
        //            model.Creator = CurrentUser.UserName;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();


        //                p.Add("@total", model.TotalAmount);
        //                p.Add("@note", model.Note);
        //                p.Add("@creator", CurrentUser.Id);
        //                p.Add("@eid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertExpense", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@eid") == null ? 0 : p.Get<int>("@eid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));

        //                else
        //                    foreach (var sc in model.Cart) {
        //                        sc.Id = 0;
        //                        var p2 = new DynamicParameters();

        //                        p2.Add("@pname", sc.ProductName);
        //                        p2.Add("@q", sc.Quantity);
        //                        p2.Add("@uprice", sc.UnitPrice);
        //                        p2.Add("@eid", model.Id);
        //                        p2.Add("@scid", 0, DbType.Int32, ParameterDirection.Output);
        //                        p2.Add("@responseMessage", "", DbType.String, size: 250,
        //                            direction: ParameterDirection.Output);

        //                        connection.Execute("dbo.spInsertExpenseCart", p2, commandType: CommandType.StoredProcedure);
        //                        sc.Id = p2.Get<int?>("@scid") == null ? 0 : p2.Get<int>("@scid");
        //                        if (sc.Id == 0)
        //                            MessageBox.Show(p.Get<string>("@responseMessage"));
        //                    }
        //            }
        //            return model;
        //        }

        //        public List<Expense> GetExpeneAll() {
        //            List<Expense> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Expense>("dbo.spSaleAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool DeleteExpense(int eid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@id", eid);
        //                p.Add("type", "Expense");
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteRecord", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public List<Purchase> GetPurchaseAll() {
        //            List<Purchase> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                output = connection.Query<Purchase>("dbo.spSaleAll").ToList();
        //            }
        //            return output;
        //        }

        //        public bool DeletePurchase(int pid) {
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();
        //                p.Add("@id", pid);
        //                p.Add("type", "Purchase");
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spDeleteRecord", p, commandType: CommandType.StoredProcedure);
        //                if (p.Get<string>("@responseMessage") == "Success")
        //                    return true;
        //                MessageBox.Show(p.Get<string>("@responseMessage"), "Error");
        //            }
        //            return false;
        //        }

        //        public Purchase InsertPurchase(Purchase model) {
        //            model.Id = 0;
        //            model.Creator = CurrentUser.UserName;

        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                // Connecting With Dapper
        //                var p = new DynamicParameters();

        //                p.Add("@total", model.TotalAmount);
        //                p.Add("@creator", CurrentUser.Id);
        //                p.Add("@pid", 0, DbType.Int32, ParameterDirection.Output);
        //                p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                connection.Execute("dbo.spInsertPurchase", p, commandType: CommandType.StoredProcedure);
        //                model.Id = p.Get<int?>("@pid") == null ? 0 : p.Get<int>("@pid");
        //                if (model.Id == 0)
        //                    MessageBox.Show(p.Get<string>("@responseMessage"));

        //                else
        //                    foreach (var sc in model.Cart) {
        //                        sc.Id = 0;
        //                        var p2 = new DynamicParameters();

        //                        p2.Add("@prid", sc.ObjectId);
        //                        p2.Add("@q", sc.Quantity);
        //                        p2.Add("@upprice", sc.UnitPurchasePrice);
        //                        p2.Add("@pid", model.Id);
        //                        p2.Add("@scid", 0, DbType.Int32, ParameterDirection.Output);
        //                        p2.Add("@responseMessage", "", DbType.String, size: 250,
        //                            direction: ParameterDirection.Output);

        //                        connection.Execute("dbo.spInsertPurchaseCart", p2, commandType: CommandType.StoredProcedure);
        //                        sc.Id = p2.Get<int?>("@scid") == null ? 0 : p2.Get<int>("@scid");
        //                        if (sc.Id == 0)
        //                            MessageBox.Show(p.Get<string>("@responseMessage"));
        //                    }
        //            }
        //            return model;
        //        }

        //        public Purchase GetPurchaseById(int pid) {
        //            var ps = new Purchase();
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                var p = new DynamicParameters();
        //                p.Add("@pid", pid);
        //                ps = connection.Query<Purchase>("dbo.spGetPurchaseById", p, commandType: CommandType.StoredProcedure)
        //                    .SingleOrDefault();
        //                ps.Cart = connection.Query<ShoppingCart>("dbo.spGetSPurchaseCartById", p,
        //                    commandType: CommandType.StoredProcedure).ToList();
        //            }
        //            return ps;
        //        }

        //        public Expense GetExpenseById(int eid) {
        //            var e = new Expense();
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                var p = new DynamicParameters();
        //                p.Add("@eid", eid);
        //                e = connection.Query<Expense>("dbo.spGetExpenseById", p, commandType: CommandType.StoredProcedure)
        //                    .SingleOrDefault();
        //                e.Cart = connection.Query<ShoppingCart>("dbo.spGetSExpenseCartById", p,
        //                    commandType: CommandType.StoredProcedure).ToList();
        //            }
        //            return e;
        //        }

        //        public List<Record> GetRecordAll() {
        //            List<Record> output;
        //            using (IDbConnection connection =
        //                new SqlConnection(CnnString(Db))) {
        //                output = connection.Query<Record>("dbo.spGetRecordAll").ToList();
        //            }
        //            return output;
        //        }


        //        public void InsertAll() {
        //            void Insert(string pName,
        //                decimal rPrice, decimal wPrice,
        //                string cat, string spec) {

        //                var catModel = new Category {
        //                    Id = 0,
        //                    Name = cat
        //                };
        //                var specModel = new Specification {
        //                    Id = 0,
        //                    Category = cat,
        //                    Name = spec
        //                };

        //                int caid = Connection[0].GetCategoryAll().Exists(c => c.Name == cat)
        //                    ? Connection[0].GetCategoryAll().Single(c => c.Name == cat).Id
        //                    : Connection[0].InsertCategory(catModel).Id;
        //                int spid = Connection[0].GetSpecificationAll().Exists(s => s.Name == spec && s.Category == cat)
        //                    ? Connection[0].GetSpecificationAll().Single(s => s.Name == spec && s.Category == cat).Id
        //                    : Connection[0].InsertSpecification(specModel, caid).Id;


        //                using (IDbConnection connection =
        //                    new SqlConnection(CnnString(Db))) {
        //                    // Connecting With Dapper
        //                    var p = new DynamicParameters();
        //                    p.Add("@sid", 1);
        //                    p.Add("@pName", pName);
        //                    p.Add("@file", pName);
        //                    p.Add("@sShop", 0);
        //                    p.Add("@sGodown", 0);
        //                    p.Add("@aStock", 0);
        //                    p.Add("@pPrice", 0.0);
        //                    p.Add("@rPrice", rPrice);
        //                    p.Add("@wPrice", wPrice);
        //                    p.Add("@mrp", 0.0);
        //                    p.Add("@caid", caid);
        //                    p.Add("@spid", spid);
        //                    p.Add("@note", "");
        //                    p.Add("@creator", CurrentUser.Id);
        //                    p.Add("@pid", 0, DbType.Int32, ParameterDirection.Output);
        //                    p.Add("@responseMessage", "", DbType.String, size: 250, direction: ParameterDirection.Output);

        //                    connection.Execute("dbo.spInsertProduct", p, commandType: CommandType.StoredProcedure);
        //                    int id = p.Get<int?>("@pid") == null ? 0 : p.Get<int>("@pid");
        //                    if (id == 0)
        //                        MessageBox.Show(p.Get<string>("@responseMessage"));
        //                }
        //            }

        //            Excel.Application xlApp = new Excel.Application();
        //            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(@"D:\list.xlsx");
        //            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
        //            Excel.Range xlRange = xlWorksheet.UsedRange;

        //            int rowCount = xlRange.Rows.Count;
        //            int colCount = xlRange.Columns.Count;


        //            //iterate over the rows and columns and print to the console as it appears in the file
        //            //excel is not zero based!!
        //            for (int i = 2; i <= rowCount; i++) {
        //                Insert(xlRange.Cells[i, 1].Value2.ToString(),
        //                    decimal.Parse(xlRange.Cells[i, 4].Value2.ToString()),
        //                    decimal.Parse(xlRange.Cells[i, 5].Value2.ToString()),
        //                    xlRange.Cells[i, 2].Value2.ToString(),
        //                    xlRange.Cells[i, 3].Value2.ToString());
        //            }

        //            //cleanup
        //            GC.Collect();
        //            GC.WaitForPendingFinalizers();

        //            //rule of thumb for releasing com objects:
        //            //  never use two dots, all COM objects must be referenced and released individually
        //            //  ex: [somthing].[something].[something] is bad

        //            //release com objects to fully kill excel process from running in the background
        //            Marshal.ReleaseComObject(xlRange);
        //            Marshal.ReleaseComObject(xlWorksheet);

        //            //close and release
        //            xlWorkbook.Close();
        //            Marshal.ReleaseComObject(xlWorkbook);

        //            //quit and release
        //            xlApp.Quit();
        //            Marshal.ReleaseComObject(xlApp);
        //        }
    }
}
