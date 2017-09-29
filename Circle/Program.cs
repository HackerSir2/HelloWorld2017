using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle
{
    class Program
    {
         //const double PI= 3.14;
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            double r = Convert.ToDouble(str);
            double num= circlePerimeter(r);
            double area = circleArea(r);
            Console.WriteLine("周长为:{0},面积为：{1}",num,area);

            Console.ReadKey();
        }
        public static double circlePerimeter(double radius) {
            return 2 * Math.PI * radius;
        }

        public static double circleArea(double radius) {
            return Math.PI * radius * radius;
        }

    }
}
