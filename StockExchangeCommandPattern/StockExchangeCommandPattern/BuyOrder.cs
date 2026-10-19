// Command Pattern
namespace StockExchangeCommandPattern
{
    // Concrete command
    // This is a command to buy stock
    public class BuyOrder : IOrder
    {
        private StockExchange _stockExchange;
        private string _stockId;
        private int _amount;

        // ctor contains all necessary data requiered by Execute() method 
        public BuyOrder(StockExchange stockExchange, string stockId, int amount)
        {
            this._stockExchange = stockExchange;
            this._stockId = stockId;
            this._amount = amount;
        }

        // implementation of IOrder interface
        public void Execute()
        {
            // Execute() method in this case is reponsible for buying stock. 
            this._stockExchange.BuyStock(this._stockId, this._amount);
        }
    }
}
