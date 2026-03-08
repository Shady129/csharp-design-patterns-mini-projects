using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Subscriber
{
    public class NewsSubscriber
    {

        public string Name { get; }

        public NewsSubscriber(string name)
        {

            Name = name;
        }


        public void Subscriber(NewsPublisher publisher)
        {
            publisher.NewNewsPublished += HandleNewNews;

        }

        public void UnSubscriber(NewsPublisher publisher)
        {
            publisher.NewNewsPublished -= HandleNewNews;
        }


        public void HandleNewNews(object sender, NewsArticle article)
        {
            Console.WriteLine($"{Name} received a new news article:");
            Console.WriteLine($"Title: {article.Title}");
            Console.WriteLine($"Content: {article.Content}");
            Console.WriteLine();
        }


    }
}
