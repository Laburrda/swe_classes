using System;

// Command Pattern
namespace StockExchangeCommandPattern
{
    // Receiver
    // This class participate in executing commands
    public class StockExchange
    {
        
        public void BuyStock(string stockId, int amount)
        {
            // temporary implementation
            Console.WriteLine("Buying of {0} stocks {1}", amount, stockId);
        }

        public void SellStock(string stockId, int amount)
        {
            // temporary implementation
            Console.WriteLine("Selling of {0} akcji {1}", amount, stockId);
        }
    }
}
