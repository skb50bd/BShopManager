using System;
using System.Collections.Generic;
using ShopLibrary.Models;

namespace ShopLibrary.DataAccess {
    public interface IDataConnection {
        // LOGIN
        bool Login(string userName, string password);
        void Logout();

        #region User
        List<User> GetUserAll();
        User InsertUser(User model);
        bool UpdateUser(User u);
        bool DeleteUserByUserName(string userName);
        bool DisableUserByUserName(string userName);
        bool NewUserNameIsValid(string userName);
        #endregion

        #region Bank Account
        BankAccount InsertBankAccount(BankAccount model);
        bool DeleteBankAccount(BankAccount model);
        bool UpdateBankAccount(BankAccount model);
        #endregion
        #region Transaction
        List<Transaction> GetTransactionsAll();
        List<Transaction> GetTransactionsByDate(DateTime _from, DateTime _to);
        List<Transaction> GetTransactionsByBankAccount(BankAccount bankAccount, DateTime _from, DateTime _to);
        List<BankAccount> GetBankAccountsAll();
        Transaction InsertTransaction(Transaction model);
        bool DeleteTransaction(Transaction model);
        #endregion

        #region Shop
        Shop InsertShop(Shop model);
        List<Shop> GetShopsAll();
        bool UpdateShop(Shop model);
        bool DeleteShop(Shop model);
        #endregion

        #region Customer
        Customer InsertCustomer(Customer model);
        List<Customer> GetCustomersAll();
        bool UpdateCustomer(Customer model);
        bool DeleteCustomer(Customer model);
        bool DisableCustomer(Customer model);
        #endregion
        #region Debt / Due
        DebtCollection CollectDebt(DebtCollection due);
        List<DebtCollection> GetDebtCollectionAll();
        List<DebtCollection> GetDebtCollectionByDate(DateTime _from, DateTime _to);
        bool DeleteDebtCollection(DebtCollection due);
        List<DebtCollection> GetDebtCollectionByCustomer(Customer customer, DateTime _from, DateTime _to);
        //List<Record> GetCustomerRecordById(int cid);
        //bool DeleteRecord(string type, int id);
        #endregion

        #region Supplier
        Supplier InsertSupplier(Supplier model);
        List<Supplier> GetSupplierAll();
        bool UpdateSupplier(Supplier model);
        bool DeleteSupplier(Supplier model);
        bool DisableSupplier(Supplier model);
        #endregion
        #region Repay
        Repayment Repay(Repayment model);
        List<Repayment> GetRepaymentAll();
        List<Repayment> GetRepaymentBySupplier(Supplier supplier, DateTime _from, DateTime _to);
        List<Repayment> GetRepaymentByDate(DateTime _from, DateTime _to);
        bool DeleteRepayment(Repayment model);
        //List<Record> GetCustomerRecordById(int cid);
        //bool DeleteRecord(string type, int id);
        #endregion

        #region Employee
        Employee InsertEmployee(Employee model);
        List<Employee> GetEmployeeAll();
        bool UpdateEmployee(Employee model);
        bool DeleteEmployee(Employee model);
        bool DisableEmployee(Employee model);
        #endregion
        #region Salary
        Payment Pay(Payment model);
        List<Payment> GetPaymentAll();
        List<Payment> GetPaymentByEmployee(Employee employee, DateTime _from, DateTime _to);
        List<Payment> GetPaymentByDate(DateTime _from, DateTime _to);
        bool DeletePayment(Payment model);
        //List<Record> GetCustomerRecordById(int cid);
        //bool DeleteRecord(string type, int id);
        #endregion

        #region Category
        Category InsertCategory(Category model);
        bool DeleteCategory(Category model);
        bool UpdateCategory(Category model);
        List<Category> GetCategoryAll();
        #endregion

        #region Product
        Product InsertProduct(Product model);
        List<Product> GetProductsAll();
        bool UpdateProduct(Product model);
        bool DeleteProduct(Product model);
        #endregion

        #region Sale
        //bool CheckSale(Sale model);
        Sale InsertSale(Sale model);
        Sale InsertOldSale(Sale model);
        bool DeleteSale(Sale model);
        List<Sale> GetSaleByCustomer(Customer customer, DateTime _from, DateTime _to);
        List<Sale> GetSaleByDate(DateTime _from, DateTime _to);
        List<Sale> GetSaleByShop(Shop shop, DateTime _from, DateTime _to);
        List<Sale> GetSaleAll();
        #endregion
        #region Draft
        Sale SaveSale(Sale model);
        bool DeleteSavedSale(Sale model);
        List<Sale> GetSavedSaleAll();
        #endregion
        #region Refund

        Refund InsertRefund(Refund model);
        bool DeleteRefund(Refund model);
        List<Refund> GetRefundAll();
        List<Refund> GetRefundByDate(DateTime _from, DateTime _to);
        List<Refund> GetRefundBySale(Sale sale);
        List<Refund> GetRefundByCustomer(Customer customer, DateTime _from, DateTime _to);

        #endregion

        #region Expense
        Expense InsertExpense(Expense model);
        List<Expense> GetExpeneAll();
        List<Expense> GetExpenseByDate(DateTime _from, DateTime _to);
        bool DeleteExpense(Expense model);
        #endregion

        #region Purchase
        Purchase InsertPurchase(Purchase model);
        List<Purchase> GetPurchaseAll();
        List<Purchase> GetPurchaseByDate(DateTime _from, DateTime _to);
        List<Purchase> GetPurchaseBySupplier(Supplier supplier, DateTime _from, DateTime _to);
        bool DeletePurchase(Purchase model);
        #endregion
        #region Draft
        Purchase SavePurchase (Purchase model);
        bool DeleteSavedPurchase(Purchase model);
        List<Purchase> GetSavedPurchaseAll();
        #endregion
        #region PurchaseReturn

        PurchaseReturn InsertPurchaseReturn(PurchaseReturn model);
        bool DeletePurchaseReturn(PurchaseReturn model);
        List<PurchaseReturn> GetPurchaseReturnAll();
        List<PurchaseReturn> GetPurchaseReturnByDate(DateTime _from, DateTime _to);
        List<PurchaseReturn> GetPurchaseReturnByPurchase(Purchase purchase);
        List<PurchaseReturn> GetPurchaseReturnBySupplier(Supplier supplier, DateTime _from, DateTime _to);

        #endregion

        #region CashModification

        CashModification InsertCashModification(CashModification model);
        List<CashModification> GetCashModificationAll();
        bool DeleteCashModification(CashModification model);

        #endregion

        Cash GetCurrentCash();
    }
}