using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SParseMatrix
{
    public class StopWatch
    {
        Stopwatch s;
        public StopWatch()
        {
            if (s==null)
            {
                s = new Stopwatch();
            }
            else
            {
                s.Reset();
            }
        }

        public void Start()
        {
            s.Start();
        }

        public void Stop()
        {
            s.Stop();
        }

        public void Reset()
        {
            s.Reset();
        }

        public long Elasped()
        {
            return s.ElapsedTicks;
        }

        public bool isRunning()
        {
            return s.IsRunning;
        }
    }
}
