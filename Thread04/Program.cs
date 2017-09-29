using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread04
{
    class Program
    {
        static void ThreadMethod()
        {
            Console.WriteLine("线程开始" + Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("线程结束");
        }
        static void Main(string[] args)
        {
            Task t = new Task(ThreadMethod);
            t.Start();
            //TaskFactory tf = new TaskFactory();
            //Task t = tf.StartNew(ThreadMethod);

            Console.WriteLine("Main");

            Console.ReadKey();
        }
    }
}
