// Command Pattern
namespace StockExchangeCommandPattern
{
    // Abstract command
    // Common interface for all Commands
    public interface IOrder
    {
        // Execute methods usually does not contain args. 
        // All required data are passed in constructors of concrete commands 
        // (e.g. BuyOrder & SellOrder)
        void Execute();
    }
}
