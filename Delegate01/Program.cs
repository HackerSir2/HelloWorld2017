using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate01
{
    class Program
    {
        public static void Test01()
        {
            Console.WriteLine($"Test01");
        }

        public static void Test02()
        {
            Console.WriteLine($"Test02");
        }

        public static string printString01()
        {
            //Console.WriteLine("Happy");
            return "Happy";
        }
        public static string printString02()
        {
            //Console.WriteLine("Helloworld");
            return "Helloworld";
        }

        static void Main(string[] args)
        {
            Action a=Test01;
            a += Test02;
            //a();
            a -= Test01;
            //a -= Test02;
            a();
            Func<string> f=printString01;
            f += printString02;
            foreach (var printString in f())
            {
                Console.Write(printString.ToString());  //多播委托只会返回其指向的最后一个方法的返回值
            }

            //取得多播委托中所有方法的委托
            Delegate[] delegates=a.GetInvocationList();
            foreach (Delegate d in delegates)
            {
                d.DynamicInvoke(); //返回当前委托所指向的方法

            }

            //使用匿名方法赋值给委托
            Func<int, int, int> fun = delegate(int x, int y)
            {
                int temp = x + y;
                return temp;
            };
            //Lambda表达式
            //Func<int, int, int> plus = (m, n) => { int temp = m/n;
            //    return temp;
            //};
            int n=2;
            Func<int,int> plus =m=> m / n; //Lambda表达式访问外部变量n
            int num=plus(10);
            int res = fun(34,56);
            Console.WriteLine(res+" "+num);

            
            Console.ReadKey();
        }

    }
}
