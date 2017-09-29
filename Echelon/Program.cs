using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请分别输入要求面积的梯形的上底，下底，高：");
            string str1 = Console.ReadLine();
            double up= Convert.ToDouble(str1);
            string str2 = Console.ReadLine();
            double down = Convert.ToDouble(str2);
            string str3 = Console.ReadLine();
            double height = Convert.ToDouble(str3);
            double area=AreaEchelon(up,down,height);
            Console.WriteLine(area);
            Console.ReadKey();
        }
        public static double AreaEchelon(double a,double b,double c) {
            return (a + b) * c / 2;
        }

        
    }
    
}
