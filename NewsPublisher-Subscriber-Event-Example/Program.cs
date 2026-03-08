namespace News_Publisher_Subscriber
{
    public class Program
    {
        static void Main(string[] args)
        {
           NewsPublisher publisher = new NewsPublisher();

           NewsSubscriber subscriber1 = new NewsSubscriber("Subscriber1");
           NewsSubscriber subscriber2 = new NewsSubscriber("Subscriber2");


           subscriber1.Subscriber(publisher);
           subscriber2.Subscriber(publisher);


            publisher.PublishNews("Breaking News", "A significant event just happened!");

            publisher.PublishNews("Tech Update", "New gadgets are hitting the market.");


            // Unsubscribe subscriber1
            subscriber1.UnSubscriber(publisher);

            publisher.PublishNews("Weather Forecast", "Expect sunny weather for the weekend.");


            // Unsubscribe subscriber2
            subscriber2.UnSubscriber(publisher);

            publisher.PublishNews("Final Edition", "Last news update for today.");


            Console.ReadLine();


        }
    }
}
