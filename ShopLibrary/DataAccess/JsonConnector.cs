using System;
using System.Collections.Generic;
using ShopLibrary.Models;

namespace ShopLibrary.DataAccess {
    public class JsonConnector : IDataConnection {
        public bool InitiateDatabase() => true;

        public bool Login(string userName, string password) => throw new NotImplementedException();

        public void Logout() => throw new NotImplementedException();

        public List<User> GetUserAll() => throw new NotImplementedException();

        public User InsertUser(User model) => throw new NotImplementedException();

        public bool UpdateUser(User u) => throw new NotImplementedException();

        public bool DeleteUserByUserName(string userName) => throw new NotImplementedException();

        public bool DisableUserByUserName(string userName) => throw new NotImplementedException();

        public BankAccount InsertBankAccount(BankAccount model) => throw new NotImplementedException();

        public bool DeleteBankAccount(BankAccount model) => throw new NotImplementedException();

        public bool UpdateBankAccount(BankAccount model) => throw new NotImplementedException();

        public List<Transaction> GetTransactionsAll() => throw new NotImplementedException();

        public List<Transaction> GetTransactionsByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Transaction> GetTransactionsByBankAccount(BankAccount bankAccount, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<BankAccount> GetBankAccountsAll() => throw new NotImplementedException();

        public Transaction InsertTransaction(Transaction model) => throw new NotImplementedException();

        public bool DeleteTransaction(Transaction model) => throw new NotImplementedException();

        public Shop InsertShop(Shop model) => throw new NotImplementedException();

        public List<Shop> GetShopsAll() => throw new NotImplementedException();

        public bool UpdateShop(Shop model) => throw new NotImplementedException();

        public bool DeleteShop(Shop model) => throw new NotImplementedException();

        public Customer InsertCustomer(Customer model) => throw new NotImplementedException();

        public List<Customer> GetCustomersAll() => throw new NotImplementedException();

        public bool UpdateCustomer(Customer model) => throw new NotImplementedException();

        public bool DeleteCustomer(Customer model) => throw new NotImplementedException();

        public bool DisableCustomer(Customer model) => throw new NotImplementedException();

        public DebtCollection CollectDebt(DebtCollection due) => throw new NotImplementedException();

        public List<DebtCollection> GetDebtCollectionAll() => throw new NotImplementedException();

        public List<DebtCollection> GetDebtCollectionByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public bool DeleteDebtCollection(DebtCollection due) => throw new NotImplementedException();

        public List<DebtCollection> GetDebtCollectionByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public Supplier InsertSupplier(Supplier model) => throw new NotImplementedException();

        public List<Supplier> GetSupplierAll() => throw new NotImplementedException();

        public bool UpdateSupplier(Supplier model) => throw new NotImplementedException();

        public bool DeleteSupplier(Supplier model) => throw new NotImplementedException();

        public bool DisableSupplier(Supplier model) => throw new NotImplementedException();

        public Repayment Repay(Repayment model) => throw new NotImplementedException();

        public List<Repayment> GetRepaymentAll() => throw new NotImplementedException();

        public List<Repayment> GetRepaymentBySupplier(Supplier supplier, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Repayment> GetRepaymentByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public bool DeleteRepayment(Repayment model) => throw new NotImplementedException();

        public Employee InsertEmployee(Employee model) => throw new NotImplementedException();

        public List<Employee> GetEmployeeAll() => throw new NotImplementedException();

        public bool UpdateEmployee(Employee model) => throw new NotImplementedException();

        public bool DeleteEmployee(Employee model) => throw new NotImplementedException();

        public bool DisableEmployee(Employee model) => throw new NotImplementedException();

        public Payment Pay(Payment model) => throw new NotImplementedException();

        public List<Payment> GetPaymentAll() => throw new NotImplementedException();

        public List<Payment> GetPaymentByEmployee(Employee employee, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Payment> GetPaymentByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public bool DeletePayment(Payment model) => throw new NotImplementedException();

        public Category InsertCategory(Category model) => throw new NotImplementedException();

        public bool DeleteCategory(Category model) => throw new NotImplementedException();

        public bool UpdateCategory(Category model) => throw new NotImplementedException();

        public List<Category> GetCategoryAll() => throw new NotImplementedException();

        public Product InsertProduct(Product model) => throw new NotImplementedException();

        public List<Product> GetProductsAll() => throw new NotImplementedException();

        public bool UpdateProduct(Product model) => throw new NotImplementedException();

        public bool DeleteProduct(Product model) => throw new NotImplementedException();

        public Sale InsertSale(Sale model) => throw new NotImplementedException();

        public bool DeleteSale(Sale model) => throw new NotImplementedException();

        public List<Sale> GetSaleByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Sale> GetSaleByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Sale> GetSaleByShop(Shop shop, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Sale> GetSaleAll() => throw new NotImplementedException();

        public Sale SaveSale(Sale model) => throw new NotImplementedException();

        public bool DeleteSavedSale(Sale model) => throw new NotImplementedException();

        public List<Sale> GetSavedSaleAll() => throw new NotImplementedException();

        public Refund InsertRefund(Refund model) => throw new NotImplementedException();

        public bool DeleteRefund(Refund model) => throw new NotImplementedException();

        public List<Refund> GetRefundAll() => throw new NotImplementedException();

        public List<Refund> GetRefundByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<Refund> GetRefundBySale(Sale sale) => throw new NotImplementedException();

        public List<Refund> GetRefundByCustomer(Customer customer, DateTime _from, DateTime _to) => throw new NotImplementedException();

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

        public PurchaseReturn InsertPurchaseReturn(PurchaseReturn model) => throw new NotImplementedException();

        public bool DeletePurchaseReturn(PurchaseReturn model) => throw new NotImplementedException();

        public List<PurchaseReturn> GetPurchaseReturnAll() => throw new NotImplementedException();

        public List<PurchaseReturn> GetPurchaseReturnByDate(DateTime _from, DateTime _to) => throw new NotImplementedException();

        public List<PurchaseReturn> GetPurchaseReturnByPurchase(Purchase purchase) => throw new NotImplementedException();

        public List<PurchaseReturn> GetPurchaseReturnBySupplier(Supplier supplier, DateTime _from, DateTime _to) => throw new NotImplementedException();

        public bool NewUserNameIsValid(string userName) => throw new NotImplementedException();
        public CashModification InsertCashModification(CashModification model) => throw new NotImplementedException();
        public List<CashModification> GetCashModificationAll() => throw new NotImplementedException();
        public bool DeleteCashModification(CashModification model) => throw new NotImplementedException();
        public Cash GetCurrentCash() => throw new NotImplementedException();
    }
}