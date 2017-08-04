using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SParseMatrix;

namespace ConsoleApp1
{
    class Program
    {
        static StopWatch s;
        static void Main(string[] args)
        {
            s = new StopWatch();
            int numOfTimes = 10000;
            SParse parse = new SParse();
            parse.CreateTraditionalMatrix();

            Console.WriteLine("Press enter key to start benchmark");
            Console.ReadLine();

            s.Start();
            for (int i = 0; i < numOfTimes; i++)
            {
                parse.CreateSParseMy();
            }
            s.Stop();
            Console.WriteLine("My Time is:" + s.Elasped().ToString());

            s = new StopWatch();
            s.Start();
            for (int i = 0; i < numOfTimes; i++)
            {
                parse.CreateSParseSir();
            }
            s.Stop();
            Console.WriteLine("Sir Time is:" + s.Elasped().ToString());

            Console.ReadLine();
        }
    }
}
