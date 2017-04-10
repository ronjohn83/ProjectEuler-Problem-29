using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_29
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DistinctPowers());
            Console.Read();
        }

        private static double DistinctPowers()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            int counter = 0;
            double power = 0;
            List<double> list = new List<double>();

            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {
                    power = Math.Pow(i, j);
                    list.Add(power);
                }
            }

            list.Sort();
            List<double> distinct = list.Distinct().ToList();
            counter = distinct.Count;
            stopwatch.Stop();

            return counter;
        }
    }
}
