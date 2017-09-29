using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public delegate double myDelegate(double param1, double parm2);
    class Program
    {
        static void Main(string[] args)
        {
            myDelegate d;
            d = Multiply;
            Console.WriteLine(d(2,4));

            d = Divide;
            Console.WriteLine(d(8,4));
            Console.ReadLine();
        }

        public static double Multiply(double x,double y) {
            return x * y;
        }
        public static double Divide(double x,double y) {
            return x / y;
        }
    }
}
