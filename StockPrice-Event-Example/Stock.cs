using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPrice_Event_Example
{
    public class Stock
    {
        public event EventHandler<StockPriceEventArgs> PriceChanged;

        public string Symbol { get; }
        public decimal Price { get; private set; }



        public Stock(string symbol, decimal Initialprice)
        {
            Symbol = symbol;
            Price = Initialprice;
        }


        public void ChangePrice(decimal newPrice)
        {
            decimal oldPrice = Price;
            Price = newPrice;


            var args = new StockPriceEventArgs(oldPrice, newPrice);


            PriceChanged?.Invoke(this, args);

        }
    }
}
