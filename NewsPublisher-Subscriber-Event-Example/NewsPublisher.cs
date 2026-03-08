using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Subscriber
{
    public class NewsPublisher
    {

        public event EventHandler<NewsArticle> NewNewsPublished;

        public void PublishNews(string Title, string Content)
        {

            var Article = new NewsArticle(Title, Content);

            OnNewNewsPublished(Article);
        }

        protected virtual void OnNewNewsPublished(NewsArticle Article)
        {

            NewNewsPublished?.Invoke(this, Article); 
        }

    }
}
