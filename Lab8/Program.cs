using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8
{
    internal class Program
    {
        //Exercise 1:
        public static int GreaterCount(List<double> temperatures, double min)
        {
            int count = 0;
            foreach (var content in temperatures)
            {
                if (content > min)
                {
                    count++;
                }
            }

            return count;
        }
        //Exercise 2:
        static int GreaterCount(IEnumerable<double> eble, double min)
        {
            int count = 0;
            Console.WriteLine("Max value using IEnumerable: " + eble.Max());
            foreach (var content in eble)
            {
                if (content >= min)
                {
                    count++;
                }
            }

            return count;
        }
        public static void Main(string[] args)
        {
            List<double> temperatures = new List<double>();
            temperatures.Add(24.8);
            temperatures.Add(5.5);
            temperatures.Add(60);
            temperatures.Add(25.2);
            temperatures.Add(55.3);
            Console.WriteLine("No of count Which is Greater than or equle to 25 degree: " + GreaterCount((IEnumerable<double>)temperatures, 25));
            Console.ReadLine();

        }
    }
}