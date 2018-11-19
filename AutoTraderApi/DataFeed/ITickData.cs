using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFeed
{
    public interface ITickData
    {
        string Symbol { get; set; }
        DateTime Date { get; set; }
        double Price { get; set; }
        int TickVolume { get; set;}
    }
}
