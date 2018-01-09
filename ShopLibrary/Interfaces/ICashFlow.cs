using System;

namespace ShopLibrary.Models
{
    public interface ICashFlow
    {
        string Type { get; }
        decimal InFlow { get; }
        string GetInFlow { get; }
        decimal OutFlow { get; }
        string GetOutFlow { get; }
        DateTime TimeStamp { get; }
        string GetTimeStamp { get; }
        string Note { get; }
    }
}