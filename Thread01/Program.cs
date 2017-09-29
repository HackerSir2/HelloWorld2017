using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread01
{
    class Program
    {
        static void DownloadFile(Object fileName)
        {
            Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);//获取当前线程托管的唯一标识
            Thread.Sleep(1000); //1000ms
            Console.WriteLine("下载完成");
        }

        static void ThreadMethod(Object state)
        {
            Console.WriteLine("线程开始"+Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(2000);
            Console.WriteLine("线程结束");
        }

        static void Main(string[] args)
        {
            //Lamda表达式的写法
            //Thread t = new Thread(() =>
            //{
            //    Console.WriteLine("开始下载" + Thread.CurrentThread.ManagedThreadId);
            //    Thread.Sleep(1000);
            //    Console.WriteLine("下载完成");
            //});
            //Thread t = new Thread(DownloadFile);
            //t.Start("www.baidu.com");
            //Console.WriteLine();

            //MyThread myThread = new MyThread("www.baidu.com","http://www.baidu.com");
            //Thread t = new Thread(myThread.DownloadFile);
            //t.Start();

            //Thread t = new Thread(DownloadFile);//设置线程为前台线程
            //t.IsBackground = true;//设置线程为后台线程(true)
            //t.Join();
            //t.Start("xxx");
            //t.Abort();//终止线程的运行
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);
            ThreadPool.QueueUserWorkItem(ThreadMethod);

            Console.ReadKey();

        }
    }
}
