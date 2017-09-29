using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入四个整数：");
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            string str3 = Console.ReadLine();
            int num3 = Convert.ToInt32(str3);
            string str4 = Console.ReadLine();
            int num4 = Convert.ToInt32(str4);

            Console.WriteLine("{0},{1},{2},{3}这四个整数的乘积为{4}：",num1,num2,num3,num4,
                num1*num2*num3*num4);

            Console.ReadLine();
        }
    }
}
