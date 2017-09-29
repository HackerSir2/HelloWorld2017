using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        public static double Factorial(int x)
        {
            //int i = x;
            double fac = 1.0;
            while (x > 0)
            {
                fac = fac * x;
                x--;
            }
            return fac;
        }
        public static double Sum(int values)
        {
            double sum = 0;
            for (int i = 1; i <= values; i++)
            {
                sum += Factorial(i);
            }

            return sum;
        }
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            Console.WriteLine(Sum(num));


            Console.ReadKey();
        }
    }
}
