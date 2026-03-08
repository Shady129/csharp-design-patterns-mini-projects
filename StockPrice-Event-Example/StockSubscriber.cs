using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPrice_Event_Example
{
    public class StockSubscriber
    {
        public string Name { get; }

        public StockSubscriber(string name)
        {
            Name = name;
        }


        public void Subscribe(Stock stock)
        {
            stock.PriceChanged += HandlPriceChanged;

        }


        public void HandlPriceChanged(object sender, StockPriceEventArgs e)
        {
            Console.WriteLine($"{Name} noticed price change: {e.OldPrice} → {e.NewPrice}");

        }
    }
}
