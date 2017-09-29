using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contrary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个三位数的整数：");
            string str = Console.ReadLine();
            int num = Convert.ToInt32(str);
            OppositeInput(num);

            Console.ReadKey();
        }
        public static void OppositeInput(int a)
        {
            int m = a / 100;  //百位数字
            int n = a/10% 10;   //十位数字
            int k = a % 10; //个位数字
            int Number = k * 100 + n * 10 + m;
            //Console.WriteLine(k);
            string str2 = Convert.ToString(Number);
            Console.WriteLine(str2);
        }

    }
}
