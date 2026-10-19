using System.Collections.Generic;

// Command Pattern
namespace StockExchangeCommandPattern
{
    // Invoker
    // This class is reposnsible for storing and invoking commands.
    // It operate on common interface of all command, i.e. IOrder
    // This class does not known the real class of all objects implementing IOrder.
    // This class is a blind executor of all commands
    // New type of commands may be added without changing the code
    public class Broker
    {
        // stores all commands 
        private List<IOrder> _orderList = new List<IOrder>();

        // to store a command use this method
        public void PlaceOrder(IOrder order)
        {
            this._orderList.Add(order);
        }

        // execute all command 
        public void ExecuteAllOrders()
        {
            foreach (IOrder order in this._orderList)
                order.Execute();

            // remove all command after executing
            this._orderList.Clear();
        }
    }
}
