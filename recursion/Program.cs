using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            Mydelegate d;
            d = Fn;
            Console.WriteLine($"请输入一个整数：");
            string str= Console.ReadLine();
            int n = Convert.ToInt32(str);
            Console.WriteLine(d.GetType().Assembly);//获取类所在的程序集
            Console.WriteLine(d(n));


            Console.ReadKey();
        }

        public delegate int Mydelegate(int param);

        public static int Fn(int x) {
            if (0==x)
            {
                return 2;
            }
            else if (1==x)
            {
                return 3;
            }
            else
            {
              return  Fn(x-1)+Fn(x-2);
            }
        }
    }
}
