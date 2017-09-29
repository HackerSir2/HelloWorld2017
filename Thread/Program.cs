using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thread
{
    class Program
    {
        static int  Test(int i,string str)
        {
            Console.WriteLine("test"+i+str);
            //Thread.Sleep(100);
            return i;
        }

        static void Main(string[] args)
        {
            Func<int,string,int> a =Test;
           IAsyncResult ia= a.BeginInvoke(100,"siki",CallBack,a); //通过BeginInvoke开启一个新线程,ia代表线程的状态

            //while (ia.IsCompleted == false)
            //{
            //    Console.WriteLine("happy");
            //    //Thread.Sleep(100);
            //}
            //int res = a.EndInvoke(ia); //取得异步线程的返回值
            
            //Console.WriteLine($"main");
            //Console.WriteLine(res);

            //bool isEnd = ia.AsyncWaitHandle.WaitOne(1000);
            //if (isEnd)
            //{
            //    int res = a.EndInvoke(ia);
            //    Console.WriteLine(res);
            //}

               
            Console.ReadKey();
        }

        static void CallBack(IAsyncResult ar)
        {
           Func<int,string,int> a=ar.AsyncState as Func<int, string, int>;
            int res = a.EndInvoke(ar);
            Console.WriteLine(res);
        }
    }
}
