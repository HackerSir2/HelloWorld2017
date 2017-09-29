using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionDelegate
{
    class Program
    {
        static void printString()
        {
            Console.WriteLine("Hello World!");
        }

        static void printString(string str)
        {
            Console.WriteLine(str);
        }

        static void printInt(int x)
        {
            Console.WriteLine("输出整数");
        }

        static void Main(string[] args)
        {
            //Action a = printString;
            Action<int> a=printInt;
            Action<string> a2 = printString;

            Console.ReadLine();
        }
    }
}
