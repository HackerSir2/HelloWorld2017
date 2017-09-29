#define IsTest //定义一个宏，取消方法的不调用
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Obsolete
{
    [MyTest]
    class Program
    {
        [Obsolete("这个方法已被弃用，请使用方法NewMethod()",true)]
        static void OldMethod()
        {
            Console.WriteLine("Method");
        }

        static void NewMethod()
        {

        }
        [Conditional("IsTest")] //忽略方法的调用
        static void Test1()
        {
            Console.WriteLine("test1");
        }

        static void Test2()
        {
            Console.WriteLine("test2");
        }

        //[DebuggerStepThrough]
        static void PrintOut(string str,[CallerFilePath]string fileName="",[CallerLineNumber]int lineNumber=0,[CallerMemberName]string methodNumer="")
        {
            Console.WriteLine(str);
            Console.WriteLine(fileName);
            Console.WriteLine(lineNumber);
            Console.WriteLine(methodNumer);
        }

        static void Main(string[] args)
        {
            //OldMethod();
            Test1();
            Test2();
            Test1();
            PrintOut("add");
            Type type = typeof(Program); 
            Object [] array = type.GetCustomAttributes(false);
            MyTestAttribute myTest = array[0] as MyTestAttribute;
            Console.WriteLine(myTest.);

            Console.ReadKey();
        }
    }
}
