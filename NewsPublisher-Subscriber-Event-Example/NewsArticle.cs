using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News_Publisher_Subscriber
{
    public class NewsArticle
    {

        public string Title { get;}
        public string Content { get;}


        public NewsArticle(string Title, string Content)
        {
            this.Title = Title;
            this.Content = Content;

        }

    }
}
