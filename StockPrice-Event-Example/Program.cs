namespace StockPrice_Event_Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stock stock = new Stock("AAPL", 150);


            StockSubscriber subscriber1 = new StockSubscriber("Investor 1");
            subscriber1.Subscribe(stock);

            StockSubscriber subscriber2 = new StockSubscriber("Investor 2");
            subscriber2.Subscribe(stock);


            stock.ChangePrice(155);
            stock.ChangePrice(160);


            Console.ReadLine();
        }
    }
}
