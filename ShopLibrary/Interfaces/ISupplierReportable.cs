namespace ShopLibrary.Models
{
    public interface ISupplierReportable
    {
        string Id { get; }
        string Type { get; }
        string Amount { get; }
        string Due { get; }
        string Created { get; }
        string Creator { get; }
        string TimeStamp { get; }
    }
}