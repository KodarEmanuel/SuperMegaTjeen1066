using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using DataFeed;
using System.Threading;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] ticks = File.ReadAllLines("tick.txt").Skip(1).ToArray();
            ITickData[]  tick = new ITickData[ticks.Length];

            var date1 = DateTime.Now;
            for (int i = 0; i < ticks.Length; i++)
            {
                var temp = ticks[i].Split('\t');
                tick[i] = new DtnDatafeed { Symbol = temp[0], Date = DateTime.Parse(temp[1]), Price = double.Parse(temp[2].Replace('.',',')),TickVolume=int.Parse(temp[3])};
            }

            var date2 = DateTime.Now;

            var TD = new CandelStick(60, tick);




        }
    }
}
