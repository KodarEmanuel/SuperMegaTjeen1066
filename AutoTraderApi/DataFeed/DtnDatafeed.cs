using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFeed
{
    public class DtnDatafeed : ITickData
    {
        public string Symbol { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }
        public int TickVolume { get; set; }

    }
}
