// Command Pattern
namespace StockExchangeCommandPattern
{
    // Concrete command
    // This is a command to sell stock
    public class SellOrder : IOrder
    {
        private StockExchange _stockExchange;
        private string _stockId;
        private int _amount;


        // ctor conatains all necessary data requiered by Execute() method
        public SellOrder(StockExchange stockExchange, string stockId, int amount)
        {
            this._stockExchange = stockExchange;
            this._stockId = stockId;
            this._amount = amount;
        }

        // implementation of method from IOrder interface
        public void Execute()
        {
            // Execute() method in this case is reponsible for selling stock. 
            this._stockExchange.SellStock(this._stockId, this._amount);
        }
    }
}
