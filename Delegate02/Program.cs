using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate02
{
    class Program
    {
        private delegate void printString();
        private delegate String MyString();

        static void printStr(printString print)
        {
            print(); //调用委托实例中引用的方法
        }

        static void method1()
        {
            Console.WriteLine("method1");
        }

        static void method2()
        {
            Console.WriteLine("method2");
        }

        static void Main(string[] args)
        {
            int a = 40;

            MyString mystring = new MyString(a.ToString);

            //string s = mystring(); //通过委托实例去调用x中的方法
            string s = mystring.Invoke();//通过委托中的Invoke方法去调用mystring所引用到的方法

            //Console.WriteLine(a.ToString());
            Console.WriteLine(s);
            printString method;
            method = method1;
            printStr(method);
            method = method2;
            printStr(method);

            Console.ReadKey();
        }
    }
}
