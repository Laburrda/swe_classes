using StockExchangeCommandPattern;


// a simple scenario (test code)

// create infrastructure
StockExchange stockExchange = new StockExchange();
Broker broker = new Broker();

// create and place buy order (command)
BuyOrder buyOrder = new BuyOrder(stockExchange, "PZU", 24);
broker.PlaceOrder(buyOrder);

// create and place sell order (command)
SellOrder sellOrder = new SellOrder(stockExchange, "PKO", 10);
broker.PlaceOrder(sellOrder);

// ... 


// execute all orders
broker.ExecuteAllOrders();

// create and place buy order (command)
buyOrder = new BuyOrder(stockExchange, "PKO", 121);
broker.PlaceOrder(buyOrder);

// create and place buy order (command)
buyOrder = new BuyOrder(stockExchange, "GPW", 54);
broker.PlaceOrder(buyOrder);

// create and place sell order (command)
sellOrder = new SellOrder(stockExchange, "PZU", 11);
broker.PlaceOrder(sellOrder);

// execute all orders
broker.ExecuteAllOrders();

Console.ReadKey();
