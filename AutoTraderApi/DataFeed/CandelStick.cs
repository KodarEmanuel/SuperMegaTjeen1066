using NCrontab.Advanced;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataFeed
{
    public class CandelStick
    {
        public CandelStick(int sekPerBar, ITickData[] ticks)
        {
            this.ticks = ticks;

            var s = CrontabSchedule.Parse("* * * * *");
            var start = DateTime.Now;
            var end = start.AddHours(-2);
            var occurrences = s.GetNextOccurrences(start, end);

            for (int i = 0; i<ticks.Length; i++)
            {

            }
        }

        private ITickData[] ticks;
    }
}
