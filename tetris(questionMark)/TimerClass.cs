using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace tetris_questionMark_
{
    public class TimerClass : System.Timers.Timer
    {
        public TimerClass(double interval) : base(interval)
        {
        }

        public delegate void ElapsedEventHandler(object? sender, ElapsedEventArgs f, PaintEventArgs e);
    }
}
