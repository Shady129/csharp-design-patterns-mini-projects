using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockPrice_Event_Example
{
    public class StockPriceEventArgs : EventArgs
    {
        public decimal OldPrice { get; }
        public decimal NewPrice { get; }




        public StockPriceEventArgs(decimal oldPrice, decimal newPrice)
        {
            OldPrice = oldPrice;
            NewPrice = newPrice;
        }
    }
}
