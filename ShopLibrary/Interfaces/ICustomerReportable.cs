namespace ShopLibrary.Models {
    public interface ICustomerReportable
    {
        string Id { get; }
        string Type { get; }
        string Amount { get; }
        string Due { get; }
        string Profit { get; }
        string Created { get; }
        string Creator { get; }
        string TimeStamp { get; }
    }
}