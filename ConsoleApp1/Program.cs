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
            int numOfTimes = 500;
            SParse parse = new SParse();
            parse.CreateTraditionalMatrix();
            var a = parse.CreateSParseMy();
            /*for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < a.Length/3; j++)
                {
                    Console.Write(a[i, j]+"\t");
                }
                Console.Write("\n");
            }*/

            s.Start();
            for (int i = 0; i < numOfTimes; i++)
            {
                parse.CreateSParseSir();
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
