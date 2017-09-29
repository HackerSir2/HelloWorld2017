using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception01
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0, num2 = 0;
            Console.WriteLine("请输入一个整数：");
            while (true)
            {
                try
                {
                    num1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的不是一个整数，请重新输入！");
                }
           }
            Console.WriteLine("请输入另一个整数：");
            while (true)
            {
                try
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("您输入的不是一个整数，请重新输入！");
                }
            }
            Console.WriteLine("这两个整数的和为：{0}",num1+num2);

            Console.ReadKey();
        }
    }
}
