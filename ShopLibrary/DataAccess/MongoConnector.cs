using MongoDB.Bson;
using MongoDB.Driver;
using ShopLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static ShopLibrary.GlobalConfig;

namespace ShopLibrary.DataAccess {
    public class MongoConnector : IDataConnection {
        public MongoConnector () {
            if (!InitiateDatabase())
                Debug.WriteLine("Could not initiate the MongoConnector");
        }

        private static MongoClient    _client;
        private static IMongoDatabase _db;
        private static IMongoDatabase _log;

    #region Collections
        private static IMongoCollection<BankAccount> BankAccountCollection =>
            _db.GetCollection<BankAccount>("BankAccount");

        private static IMongoCollection<CashModification> CashModificationCollection =>
            _db.GetCollection<CashModification>("CashModificaion");

        private IMongoCollection<Category> CategoryCollection => _db.GetCollection<Category>("Category");
        private IMongoCollection<Customer> CustomerCollection => _db.GetCollection<Customer>("Customer");

        private IMongoCollection<DebtCollection> DebtCollection =>
            _db.GetCollection<DebtCollection>("DebtCollection");

        private IMongoCollection<Employee> EmployeeCollection => _db.GetCollection<Employee>("Employee");
        private IMongoCollection<Expense>  ExpenseCollection  => _db.GetCollection<Expense>("Expense");
        private IMongoCollection<Payment>  PaymentCollection  => _db.GetCollection<Payment>("Payment");
        private IMongoCollection<Product>  ProductCollection  => _db.GetCollection<Product>("Product");
        private IMongoCollection<Purchase> PurchaseCollection => _db.GetCollection<Purchase>("Purchase");

        private IMongoCollection<Purchase> SavedPurchaseCollection =>
            _db.GetCollection<Purchase>("SavedPurchase");

        private IMongoCollection<PurchaseReturn> PurchaseReturnCollection =>
            _db.GetCollection<PurchaseReturn>("PurchaseReturn");

        private IMongoCollection<Refund>      RefundCollection      => _db.GetCollection<Refund>("Refund");
        private IMongoCollection<Sale>        SaleCollection        => _db.GetCollection<Sale>("Sale");
        private IMongoCollection<Sale>        SavedSaleCollection   => _db.GetCollection<Sale>("SavedSale");
        private IMongoCollection<Session>     SessionCollection     => _log.GetCollection<Session>("Session");
        private IMongoCollection<Shop>        ShopCollection        => _db.GetCollection<Shop>("Shop");
        private IMongoCollection<Supplier>    SupplierCollection    => _db.GetCollection<Supplier>("Supplier");
        private IMongoCollection<Transaction> TransactionCollection => _db.GetCollection<Transaction>("Transaction");
        private IMongoCollection<User>        UserCollection        => _db.GetCollection<User>("User");
        private IMongoCollection<Cash>        CashCollection        => _db.GetCollection<Cash>("Cash");
        private IMongoCollection<Memo>        MemoCollection        => _db.GetCollection<Memo>("Memo");
        private IMongoCollection<Vouchar>     VoucharCollection     => _db.GetCollection<Vouchar>("Vouchar");
        private IMongoCollection<BulkPayment> BulkpaymentCollection => _db.GetCollection<BulkPayment>("BulkPayment");
    #endregion

        public bool InitiateDatabase () {
            Debug.WriteLine("Trying to initiate DB");

            try {
                string fileName = "connectionString";
                if (!File.Exists(fileName))
                    File.WriteAllText(fileName, "mongodb://localhost:27017");
                string connectionString = File.ReadLines(fileName).First();

                _client = new MongoClient(connectionString);
                _db     = _client.GetDatabase("BShopManDb");
                _log    = _client.GetDatabase("BShopManLog");
            }
            catch (Exception e) {
                Debug.WriteLine("Error while Initiating database:\n " + e.Message);

                return false;
            }

            return true;
        }

    #region Sequence
        public ObjectId GetNextObjectId (string collectionName) {
            IMongoCollection<BsonDocument> col = _db.GetCollection<BsonDocument>("Counter");
            FilterDefinition<BsonDocument> filter =
                new FilterDefinitionBuilder<BsonDocument>().Eq(c => c["_id"], collectionName);
            UpdateDefinition<BsonDocument> update = new UpdateDefinitionBuilder<BsonDocument>().Inc("seq", 1);
            BsonDocument ret = col.FindOneAndUpdate(filter,
                                                    update,
                                                    new FindOneAndUpdateOptions<BsonDocument> {
                                                                                                  IsUpsert = true,
                                                                                              });

            return new ObjectId(DateTime.Now, 0, 0, Convert.ToInt32(ret["seq"]));
        }
    #endregion

    #region User and Login
        public bool Login (string userName, string password) {
            foreach (User existingUser in Users)
                if (existingUser.IsRealUser(userName, password)) {
                    CurrentUser = existingUser;
                    CurrentSession = new Session {
                                                     ObjectId = new ObjectId(),
                                                     UserId   = CurrentUser.ObjectId,
                                                     UserName = CurrentUser.UserName
                                                 };

                    try {
                        SessionCollection.InsertOne(CurrentSession);
                    }
                    catch (Exception e) {
                        throw e;
                    }

                    return true;
                }

            return false;
        }

        public void Logout () {
            CurrentSession.LogoutTime = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", CurrentSession.ObjectId);
            BsonDocument update = new BsonDocument("$set", CurrentSession.ToBsonDocument());

            try {
                Session result = SessionCollection.FindOneAndUpdate(filter, update);
            }
            catch (Exception) {
                // ignored
            }
        }

        public List<User> GetUserAll () => UserCollection.AsQueryable().Where(u => u.IsActive).ToList();

        public User InsertUser (User model) {
            model.ObjectId = GetNextObjectId(nameof(User));
            model.Meta     = new Metadata(DateTime.Now, CurrentUser.UserName);

            try {
                UserCollection.InsertOne(model);
            }
            catch (Exception e) {
                Debug.WriteLine(e.Message);
                throw;
            }

            Users.Add(model);

            return model;
        }

        public bool UpdateUser (User u) {
            u.Meta.Modifier = CurrentUser.UserName;
            u.Meta.Modified = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", u.ObjectId);
            BsonDocument update = new BsonDocument("$set", u.ToBsonDocument());

            try {
                User result = UserCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception) {
                return false;
            }

            return true;
        }

        public bool DeleteUserByUserName (string userName) {
            BsonDocument filter = new BsonDocument("userName", userName);

            try {
                DeleteResult result = UserCollection.DeleteOne(filter);
                Users.Remove(Users.FirstOrDefault(u => u.UserName == userName));
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public bool DisableUserByUserName (string userName) {
            BsonDocument filter = new BsonDocument("userName", userName);
            BsonDocument update = new BsonDocument("$set", new BsonDocument("isActive", false));

            try {
                User result = UserCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public bool NewUserNameIsValid (string userName)
            => UserCollection.AsQueryable().Any(u => u.UserName == userName);
    #endregion

    #region Bank Account and Transaction
        public BankAccount InsertBankAccount (BankAccount model) {
            model.ObjectId = GetNextObjectId(nameof(BankAccount));
            model.Meta = new Metadata {
                                          Creator  = CurrentUser.UserName,
                                          Created  = DateTime.Now,
                                          Modifier = CurrentUser.UserName,
                                          Modified = DateTime.Now
                                      };

            try {
                BankAccountCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            BankAccounts = GetBankAccountsAll();

            return BankAccounts.SingleOrDefault(ba => ba.AccountName == model.AccountName);
        }

        public async Task<bool> DeleteBankAccount (BankAccount model) {
            BsonDocument filter  = new BsonDocument("_id", model.ObjectId);
            BsonDocument tFilter = new BsonDocument("bankAccountId", model.BankAccountId);

            try {
                async Task DeleteTransactionsAsync () {
                    DeleteResult tResult = await TransactionCollection.DeleteManyAsync(tFilter);
                    DeleteResult result  = BankAccountCollection.DeleteOne(filter);
                    if (tResult.DeletedCount > 0)
                        BankAccounts.Remove(model);
                }

                await DeleteTransactionsAsync();
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public bool UpdateBankAccount (BankAccount model) {
            model.Meta.Modifier = CurrentUser.UserName;
            model.Meta.Modified = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                BankAccount result = BankAccountCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<Transaction> GetTransactionsAll ()
            => TransactionCollection.AsQueryable().OrderByDescending(t => t.Meta.Created).ToList();

        public List<Transaction> GetTransactionsByDate (DateTime @from, DateTime to)
            => TransactionCollection
               .AsQueryable()
               .Where(t => t.Meta.Created >= @from && t.Meta.Created <= to)
               .OrderByDescending(t => t.Meta.Created)
               .ToList();

        public List<Transaction> GetTransactionsByBankAccount (BankAccount bankAccount, DateTime @from, DateTime to)
            => TransactionCollection
               .AsQueryable()
               .Where(t => t.BankAccountId == bankAccount.ObjectId
                        && t.Meta.Created >= @from
                        && t.Meta.Created <= to)
               .OrderByDescending(t => t.Meta.Created)
               .ToList();

        public List<BankAccount> GetBankAccountsAll () => BankAccountCollection.AsQueryable().ToList();

        public Transaction InsertTransaction (Transaction model) {
            model.ObjectId      = GetNextObjectId(nameof(Transaction));
            model.Meta.Modifier = CurrentUser.UserName;
            model.Meta.Modified = DateTime.Now;

            try {
                BsonDocument filter = new BsonDocument("_id", model.BankAccountId);
                BsonDocument update = new BsonDocument("$inc",
                                                       new BsonDocument("currentBalance",
                                                                        model.TransactionType == TransactionType.Deposit
                                                                            ? model.Amount
                                                                            : (-1) * model.Amount));
                BankAccountCollection.UpdateOne(filter, update);
                TransactionCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public bool DeleteTransaction (Transaction model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult tResult = TransactionCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Shop
        public Shop InsertShop (Shop model) {
            model.ObjectId = GetNextObjectId(nameof(Shop));
            model.Meta = new Metadata {
                                          Creator  = CurrentUser.UserName,
                                          Created  = DateTime.Now,
                                          Modifier = CurrentUser.UserName,
                                          Modified = DateTime.Now
                                      };

            try {
                ShopCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Shops = GetShopsAll();

            return Shops.SingleOrDefault(ba => ba.ShopId == model.ShopId);
        }

        public List<Shop> GetShopsAll () => ShopCollection.AsQueryable().ToList();

        public bool UpdateShop (Shop model) {
            model.Meta.Modifier = CurrentUser.UserName;
            model.Meta.Modified = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Shop result = ShopCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public bool DeleteShop (Shop model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = ShopCollection.DeleteOne(filter);
                Shops.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Customer and Debts (Due)
        public Customer InsertCustomer (Customer model) {
            model.ObjectId = GetNextObjectId(nameof(Customer));
            model.Meta     = new Metadata(DateTime.Now, CurrentUser.UserName);

            try {
                CustomerCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Customers.Add(model);

            return model;
        }

        public List<Customer> GetCustomersAll ()
            => CustomerCollection
               .AsQueryable()
               .Where(c => c.IsActive)
               .OrderByDescending(c => c.Meta.Created)
               .ToList();

        public List<DebtCollection> GetDebtCollectionByDate (DateTime @from, DateTime to)
            => DebtCollection
               .AsQueryable()
               .Where(dc => dc.Meta.Created >= @from && dc.Meta.Created <= to)
               .OrderByDescending(dc => dc.Meta.Created)
               .ToList();

        public List<DebtCollection> GetDebtCollectionByCustomer (Customer customer, DateTime @from, DateTime to)
            => DebtCollection
               .AsQueryable()
               .Where(dc => dc.CustomerId == customer.ObjectId
                         && dc.Meta.Created >= @from
                         && dc.Meta.Created <= to)
               .OrderByDescending(dc => dc.Meta.Created)
               .ToList();

        public bool UpdateCustomer (Customer model) {
            model.Meta.Modifier = CurrentUser.UserName;
            model.Meta.Modified = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Customer result = CustomerCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            Customers.Remove(Customers.Single(c => c.ObjectId == model.ObjectId));
            Customers.Add(model);

            return true;
        }

        public bool DeleteCustomer (Customer model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = CustomerCollection.DeleteOne(filter);
                Customers.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            Customers.Remove(model);

            return true;
        }

        public bool DisableCustomer (Customer model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", new BsonDocument("isActive", false));

            try {
                Customer result = CustomerCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public DebtCollection CollectDebt (DebtCollection model) {
            model.ObjectId = GetNextObjectId(nameof(Models.DebtCollection));
            model.Meta     = new Metadata();

            try {
                BsonDocument filter = new BsonDocument("_id", model.CustomerId);
                BsonDocument update = new BsonDocument("$inc", new BsonDocument("debt", (-1) * model.Amount));
                CustomerCollection.UpdateOne(filter, update);
                DebtCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<DebtCollection> GetDebtCollectionAll ()
            => DebtCollection
               .AsQueryable()
               .OrderByDescending(dc => dc.Meta.Created)
               .ToList();

        public bool DeleteDebtCollection (DebtCollection model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = DebtCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Category -Product
    #region Category
        public Category InsertCategory (Category model) {
            model.ObjectId = GetNextObjectId(nameof(Category));

            try {
                CategoryCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Categories = GetCategoryAll();

            return Categories.SingleOrDefault(c => c.ObjectId == model.ObjectId);
        }

        public bool DeleteCategory (Category model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = CategoryCollection.DeleteOne(filter);
                Categories.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public bool UpdateCategory (Category model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Category result = CategoryCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            Categories.Remove(Categories.Single(c => c.ObjectId == model.ObjectId));
            Categories.Add(model);

            return true;
        }

        public List<Category> GetCategoryAll ()
            => CategoryCollection
               .AsQueryable()
               .ToList();
    #endregion

    #region Product
        public Product InsertProduct (Product model) {
            model.ObjectId = GetNextObjectId(nameof(Product));
            model.Meta     = new Metadata(DateTime.Now, CurrentUser.UserName);

            try {
                ProductCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Products.Add(model);

            return model;
        }

        public List<Product> GetProductsAll ()
            => ProductCollection
               .AsQueryable()
               .OrderBy(p => p.ProductName)
               .ToList();

        public bool UpdateProduct (Product model) {
            model.Meta.Modifier = CurrentUser.UserName;
            model.Meta.Modified = DateTime.Now;
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Product result = ProductCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            Products.Remove(Products.Single(c => c.ObjectId == model.ObjectId));
            Products.Add(model);

            return true;
        }

        public bool DeleteProduct (Product model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = ProductCollection.DeleteOne(filter);
                Products.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion
    #endregion

    #region Supplier and Repayments
        public Supplier InsertSupplier (Supplier model) {
            model.ObjectId = GetNextObjectId(nameof(Supplier));
            model.Meta = new Metadata {
                                          Creator  = CurrentUser.UserName,
                                          Created  = DateTime.Now,
                                          Modifier = CurrentUser.UserName,
                                          Modified = DateTime.Now
                                      };

            try {
                SupplierCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Suppliers.Add(model);

            return model;
        }

        public List<Supplier> GetSupplierAll ()
            => SupplierCollection
               .AsQueryable()
               .Where(s => s.IsActive)
               .ToList();

        public bool UpdateSupplier (Supplier model) {
            model.Meta.Modify();
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Supplier result = SupplierCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            Suppliers.Remove(Suppliers.Single(c => c.ObjectId == model.ObjectId));
            Suppliers.Add(model);

            return true;
        }

        public bool DeleteSupplier (Supplier model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = SupplierCollection.DeleteOne(filter);
                Suppliers.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            Suppliers.Remove(model);

            return true;
        }

        public bool DisableSupplier (Supplier model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", new BsonDocument("isActive", false));

            try {
                Supplier result = SupplierCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public Repayment Repay (Repayment model) {
            model.ObjectId = GetNextObjectId(nameof(Repayment));
            model.Meta     = new Metadata();

            try {
                BsonDocument filter = new BsonDocument("_id", model.SupplierId);
                BsonDocument update = new BsonDocument("$inc", new BsonDocument("payable", (-1) * model.Amount));
                SupplierCollection.UpdateOne(filter, update);
                _db.GetCollection<Repayment>("Repayment").InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<Repayment> GetRepaymentBySupplier (Supplier supplier, DateTime @from, DateTime to)
            => _db.GetCollection<Repayment>("Repayment")
                  .AsQueryable()
                  .Where(r => r.SupplierId == supplier.ObjectId
                           && r.Meta.Created >= @from
                           && r.Meta.Created <= to)
                  .OrderByDescending(r => r.Meta.Created)
                  .ToList();

        public List<Repayment> GetRepaymentByDate (DateTime @from, DateTime to)
            => _db.GetCollection<Repayment>("Repayment")
                  .AsQueryable()
                  .Where(r => r.Meta.Created >= @from
                           && r.Meta.Created <= to)
                  .OrderByDescending(r => r.Meta.Created)
                  .ToList();

        public List<Repayment> GetRepaymentAll ()
            => _db.GetCollection<Repayment>("Repayment")
                  .AsQueryable()
                  .OrderByDescending(r => r.Meta.Created)
                  .ToList();

        public bool DeleteRepayment (Repayment model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = _db.GetCollection<Repayment>("Repayment").DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Employee and Salary
        public Employee InsertEmployee (Employee model) {
            model.ObjectId = GetNextObjectId(nameof(Employee));
            model.Meta     = new Metadata();

            try {
                EmployeeCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            Employees.Add(model);

            return model;
        }

        public List<Employee> GetEmployeeAll ()
            => EmployeeCollection
               .AsQueryable()
               .Where(e => e.IsActive)
               .OrderByDescending(e => e.JoinDate)
               .ToList();

        public List<Payment> GetPaymentByEmployee (Employee employee, DateTime @from, DateTime to)
            => PaymentCollection
               .AsQueryable()
               .Where(p => p.EmployeeId == employee.ObjectId
                        && p.Meta.Created >= @from
                        && p.Meta.Created <= to)
               .OrderByDescending(p => p.Meta.Created)
               .ToList();

        public List<Payment> GetPaymentByDate (DateTime @from, DateTime to)
            => PaymentCollection
               .AsQueryable()
               .Where(p => p.Meta.Created >= @from
                        && p.Meta.Created <= to)
               .OrderByDescending(p => p.Meta.Created)
               .ToList();

        public bool UpdateEmployee (Employee model) {
            model.Meta.Modify();
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", model.ToBsonDocument());

            try {
                Employee result = EmployeeCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            Employees.Remove(Employees.Single(c => c.ObjectId == model.ObjectId));
            Employees.Add(model);

            return true;
        }

        public bool DeleteEmployee (Employee model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = EmployeeCollection.DeleteOne(filter);
                Employees.Remove(model);
            }
            catch (Exception e) {
                return false;
            }

            Employees.Remove(model);

            return true;
        }

        public bool DisableEmployee (Employee model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);
            BsonDocument update = new BsonDocument("$set", new BsonDocument("isActive", false));

            try {
                Employee result = EmployeeCollection.FindOneAndUpdate(filter, update);

                if (result == null)
                    return false;
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public Payment Pay (Payment model) {
            model.ObjectId = GetNextObjectId(nameof(Payment));
            model.Meta     = new Metadata();

            try {
                BsonDocument filter = new BsonDocument("_id", model.EmployeeId);
                BsonDocument update = new BsonDocument("$inc", new BsonDocument("currentBalance", (-1) * model.Amount));
                EmployeeCollection.UpdateOne(filter, update);
                PaymentCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<Payment> GetPaymentAll ()
            => PaymentCollection
               .AsQueryable()
               .OrderByDescending(p => p.Meta.Created)
               .ToList();

        public bool DeletePayment (Payment model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = PaymentCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Sale
        public Sale InsertSale (Sale model) {
            model.ObjectId = GetNextObjectId(nameof(Sale));
            model.Meta     = new Metadata();

            try {
                foreach (ShoppingCart cart in model.Cart) {
                    BsonDocument filter  = new BsonDocument("_id", cart.ProductId);
                    Product      product = ProductCollection.AsQueryable().Single(p => p.ObjectId == cart.ProductId);
                    product.ShopStock -= cart.BaseQuantity;

                    if (product.ShopStock < 0) {
                        product.GodownStock += product.ShopStock;
                        product.ShopStock   =  0;
                    }

                    BsonDocument update = new BsonDocument("$set", product.ToBsonDocument());
                    Product      result = ProductCollection.FindOneAndUpdate(filter, update);
                }

                SaleCollection.InsertOne(model);

                Memo memo = new Memo(model,
                                     CustomerCollection
                                         .AsQueryable()
                                         .FirstOrDefault(c => c.ObjectId == model.CustomerId),
                                     Shops.FirstOrDefault(s => s.ObjectId == model.ShopId));
                SaveMemo(memo);

                CurrentCash = UpdateCash(model);

                if (model.CustomerId != ObjectId.Empty) {
                    BsonDocument filter = new BsonDocument("_id", model.CustomerId);
                    BsonDocument update =
                        new BsonDocument("$inc", new BsonDocument("debt", model.Payable - model.Paid));
                    CustomerCollection.UpdateOne(filter, update);
                }
            }
            catch (Exception e) {
                Debug.WriteLine(e.Message);

                throw e;
            }

            return model;
        }

        public Sale InsertOldSale (Sale model) {
            model.ObjectId = GetNextObjectId("OldSale");
            SaleCollection.InsertOne(model);

            return model;
        }

        public bool DeleteSale (Sale model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = SaleCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<Sale> GetSaleByCustomer (Customer customer, DateTime @from, DateTime to)
            => SaleCollection
               .AsQueryable()
               .Where(s => s.CustomerId == customer.ObjectId
                        && s.DealTime >= @from
                        && s.DealTime < to)
               .OrderByDescending(s => s.DealTime)
               .ToList();

        public List<Sale> GetSaleByDate (DateTime @from, DateTime to)
            => SaleCollection
               .AsQueryable()
               .Where(s => s.DealTime >= @from && s.DealTime < to)
               .OrderByDescending(s => s.DealTime)
               .ToList();

        public List<Sale> GetSaleByShop (Shop shop, DateTime @from, DateTime to)
            => SaleCollection
               .AsQueryable()
               .Where(s => s.ShopId == shop.ObjectId
                        && s.DealTime >= @from
                        && s.DealTime < to)
               .OrderByDescending(s => s.DealTime)
               .ToList();

        public List<Sale> GetSaleAll ()
            => SaleCollection
               .AsQueryable()
               .OrderByDescending(s => s.DealTime)
               .ToList();
    #endregion

    #region Drafts
        public Sale SaveSale (Sale model) {
            model.ObjectId = GetNextObjectId("SavedSale");
            model.Meta     = new Metadata();

            try {
                SavedSaleCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public bool DeleteSavedSale (Sale model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = SavedSaleCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<Sale> GetSavedSaleAll ()
            => SavedSaleCollection
               .AsQueryable()
               .OrderByDescending(s => s.Meta.Created)
               .ToList();
    #endregion

    #region Expense
        public Expense InsertExpense (Expense model) {
            model.ObjectId     = GetNextObjectId(nameof(Expense));
            model.Meta.Creator = CurrentUser.UserName;
            model.Meta.Modify();

            try {
                ExpenseCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<Expense> GetExpeneAll ()
            => ExpenseCollection
               .AsQueryable()
               .OrderByDescending(e => e.Meta.Created)
               .ToList();

        public List<Expense> GetExpenseByDate (DateTime @from, DateTime to)
            => ExpenseCollection
               .AsQueryable()
               .Where(s => s.Meta.Created >= @from
                        && s.Meta.Created < to)
               .OrderByDescending(e => e.Meta.Created)
               .ToList();

        public bool DeleteExpense (Expense model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = ExpenseCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Purchase
        public Purchase InsertPurchase (Purchase model) {
            model.ObjectId = GetNextObjectId(nameof(Purchase));
            model.Meta     = new Metadata();

            try {
                foreach (ShoppingCart cart in model.Cart) {
                    BsonDocument filter  = new BsonDocument("_id", cart.ProductId);
                    Product      product = Products.First(p => p.ObjectId == cart.ProductId);
                    Products.Remove(product);
                    product.PurchasePrice =
                        product.ShopStock + product.GodownStock + cart.BaseQuantity == 0.00
                            ? 0
                            : ((decimal) (product.ShopStock + product.GodownStock) * product.PurchasePrice
                             + cart.NetPurchasePrice)
                            / (decimal) (product.ShopStock + product.GodownStock + cart.BaseQuantity);
                    product.GodownStock += cart.BaseQuantity;

                    BsonDocument update = new BsonDocument("$set", product.ToBsonDocument());
                    Product      result = ProductCollection.FindOneAndUpdate(filter, update);
                }

                PurchaseCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);

                if (model.Due != 0 && model.SupplierId != ObjectId.Empty) {
                    BsonDocument filter = new BsonDocument("_id", model.SupplierId);
                    BsonDocument update = new BsonDocument("$inc", new BsonDocument("payable", model.Due));
                    SupplierCollection.UpdateOne(filter, update);
                }
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<Purchase> GetPurchaseAll ()
            => PurchaseCollection
               .AsQueryable()
               .OrderByDescending(p => p.DealTime)
               .ToList();

        public List<Purchase> GetPurchaseByDate (DateTime @from, DateTime to)
            => PurchaseCollection
               .AsQueryable()
               .Where(s => s.DealTime >= @from
                        && s.DealTime < to)
               .OrderByDescending(p => p.DealTime)
               .ToList();

        public List<Purchase> GetPurchaseBySupplier (Supplier supplier, DateTime @from, DateTime to)
            => PurchaseCollection
               .AsQueryable()
               .Where(s => s.SupplierId == supplier.ObjectId
                        && s.DealTime >= @from
                        && s.DealTime < to)
               .OrderByDescending(p => p.DealTime)
               .ToList();

        public bool DeletePurchase (Purchase model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = PurchaseCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion

    #region Drafts
        public Purchase SavePurchase (Purchase model) {
            model.ObjectId = GetNextObjectId("SavePurchase");
            ;
            model.Meta = new Metadata();

            try {
                SavedPurchaseCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public bool DeleteSavedPurchase (Purchase model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = SavedPurchaseCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<Purchase> GetSavedPurchaseAll ()
            => SavedPurchaseCollection
               .AsQueryable()
               .OrderByDescending(sp => sp.DealTime)
               .ToList();
    #endregion

    #region Refund
        public Refund InsertRefund (Refund model) {
            model.ObjectId = GetNextObjectId(nameof(Refund));
            model.Meta     = new Metadata();

            try {
                foreach (ShoppingCart cart in model.Cart) {
                    BsonDocument filter = new BsonDocument("_id", cart.ProductId);
                    BsonDocument update = new BsonDocument("$inc", new BsonDocument("shopStock", cart.BaseQuantity));
                    ProductCollection.UpdateOne(filter, update);
                }

                RefundCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public bool DeleteRefund (Refund model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = RefundCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<Refund> GetRefundAll ()
            => _db.GetCollection<Refund>("Refund")
                  .AsQueryable()
                  .OrderByDescending(r => r.Meta.Created)
                  .ToList();

        public List<Refund> GetRefundByCustomer (Customer customer, DateTime @from, DateTime to)
            => RefundCollection
               .AsQueryable()
               .Where(r => r.CustomerId == customer.ObjectId
                        && r.Meta.Created >= @from
                        && r.Meta.Created <= to)
               .OrderByDescending(r => r.Meta.Created)
               .ToList();

        public List<Refund> GetRefundByDate (DateTime @from, DateTime to)
            => RefundCollection
               .AsQueryable()
               .Where(s => s.Meta.Created >= @from
                        && s.Meta.Created < to)
               .OrderByDescending(r => r.Meta.Created)
               .ToList();

        public List<Refund> GetRefundBySale (Sale sale)
            => RefundCollection
               .AsQueryable()
               .Where(s => s.SaleId == sale.ObjectId)
               .OrderByDescending(r => r.Meta.Created)
               .ToList();
    #endregion

    #region Purchase Return
        public PurchaseReturn InsertPurchaseReturn (PurchaseReturn model) {
            model.ObjectId = GetNextObjectId(nameof(PurchaseReturn));
            model.Meta     = new Metadata();

            try {
                foreach (ShoppingCart cart in model.Cart) {
                    BsonDocument filter = new BsonDocument("_id", cart.ProductId);
                    BsonDocument update =
                        new BsonDocument("$inc", new BsonDocument("shopStock", (-1) * cart.BaseQuantity));
                    ProductCollection.UpdateOne(filter, update);
                }

                PurchaseReturnCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public bool DeletePurchaseReturn (PurchaseReturn model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = PurchaseReturnCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }

        public List<PurchaseReturn> GetPurchaseReturnAll ()
            => PurchaseReturnCollection
               .AsQueryable()
               .OrderByDescending(pr => pr.Meta.Created)
               .ToList();

        public List<PurchaseReturn> GetPurchaseReturnByDate (DateTime @from, DateTime to)
            => PurchaseReturnCollection
               .AsQueryable()
               .Where(p => p.Meta.Created >= @from
                        && p.Meta.Created <= to)
               .OrderByDescending(pr => pr.Meta.Created)
               .ToList();

        public List<PurchaseReturn> GetPurchaseReturnByPurchase (Purchase purchase)
            => PurchaseReturnCollection
               .AsQueryable()
               .Where(p => p.PurchaseId == purchase.ObjectId)
               .OrderByDescending(pr => pr.Meta.Created)
               .ToList();

        public List<PurchaseReturn> GetPurchaseReturnBySupplier (Supplier supplier, DateTime @from, DateTime to)
            => PurchaseReturnCollection
               .AsQueryable()
               .Where(p => p.SupplierId == supplier.ObjectId
                        && p.Meta.Created >= @from
                        && p.Meta.Created <= to)
               .OrderByDescending(pr => pr.Meta.Created)
               .ToList();
    #endregion

    #region Cash Modification
        public CashModification InsertCashModification (CashModification model) {
            model.ObjectId = GetNextObjectId(nameof(CashModification));
            model.Meta     = new Metadata();

            try {
                CashModificationCollection.InsertOne(model);
                CurrentCash = UpdateCash(model);
            }
            catch (Exception e) {
                throw e;
            }

            return model;
        }

        public List<CashModification> GetCashModificationAll () => CashModificationCollection.AsQueryable().ToList();

        public bool DeleteCashModification (CashModification model) {
            BsonDocument filter = new BsonDocument("_id", model.ObjectId);

            try {
                DeleteResult result = CashModificationCollection.DeleteOne(filter);
            }
            catch (Exception e) {
                return false;
            }

            return true;
        }
    #endregion


    #region Memo
        public List<Memo> GetAllMemo () => MemoCollection.AsQueryable().ToList();

        public List<Memo> GetAllMemo (DateTime start, DateTime end, Shop shop = null) =>
            shop == null
                ? MemoCollection.AsQueryable()
                                .Where(m => m.Meta.Created >= start
                                         && m.Meta.Created <= end)
                                .ToList()
                : MemoCollection.AsQueryable()
                                .Where(m => m.Meta.Created >= start
                                         && m.Meta.Created <= end
                                         && m.ShopId == shop.ObjectId)
                                .ToList();

        public Memo GetMemo (ObjectId id) => MemoCollection.AsQueryable().FirstOrDefault(m => m.ObjectId == id);

        public void SaveMemo (Memo model) {
            MemoCollection.InsertOne(model);
        }

        public void DeleteMemo (Memo model) {
            MemoCollection.DeleteOne(m => m.ObjectId == model.ObjectId);
        }
    #endregion

    //#region Vouchar
    //    public List<Vouchar> GetAllVouchars () => VoucharCollection.AsQueryable().ToList();
    //    public List<Vouchar> GetAllVouchars(DateTime start, DateTime end) => 
    //        VoucharCollection.AsQueryable()
    //                            .Where(m => m.Meta.Created >= start
    //                                     && m.Meta.Created <= end)
    //                            .ToList();
    //    public Vouchar       GetVouchar (ObjectId id)   => VoucharCollection.AsQueryable().FirstOrDefault(v => v.ObjectId == id);
    //    public void SaveVouchar (Vouchar model) => VoucharCollection.InsertOne(model);
    //    public void DeleteVouchar (Vouchar model) => VoucharCollection.DeleteOne(v => v.ObjectId == model.ObjectId);
    ////#endregion

    #region Bulkpayment
        public bool Payall (BulkPayment model) {
            model.Meta = new Metadata(DateTime.Now, CurrentUser.UserName);

            try {
                // EmployeeCollection.UpdateMany(new BsonDocument(), new BsonDocument("$set", new BsonDocument("currentBalance", "$currentBalance" + "$monthlySalary")));
                List<Employee> employees = GetEmployeeAll();

                foreach (Employee employee in employees) {
                    employee.Balance = employee.Balance + employee.MonthlySalary;
                    UpdateEmployee(employee);
                }

                BulkpaymentCollection.InsertOne(model);
            }
            catch (Exception e) {
                throw e;
            }

            return true;
        }

        public BulkPayment LatestPay ()
            => BulkpaymentCollection.AsQueryable().OrderByDescending(p => p.Meta.Created).FirstOrDefault();
    #endregion


        public Cash GetCurrentCash () => CashCollection.AsQueryable().SingleOrDefault();

        private Cash UpdateCash (ICashFlow cashFlow) {
            decimal      m      = cashFlow.InFlow - cashFlow.OutFlow;
            BsonDocument filter = new BsonDocument("_id", CurrentCash.ObjectId);
            BsonDocument update = new BsonDocument("$inc", new BsonDocument("current", m));
            Cash         c      = CashCollection.FindOneAndUpdate<Cash>(filter, update);

            return c;
        }
    }
}
