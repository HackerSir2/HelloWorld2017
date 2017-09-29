using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int num1 = Convert.ToInt32(str1);
            string str2 = Console.ReadLine();
            int num2 = Convert.ToInt32(str2);
            Console.WriteLine("交换前num1:{0},num2:{1}",num1,num2);
            swapNumber(num1,num2);

            Console.ReadKey();
        }
        public static void swapNumber(int a,int b)
        {
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("交换后num1：{0}，num2:{1}",a,b);
        }   
    }
   

}
