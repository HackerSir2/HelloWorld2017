using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread05
{
    class Program
    {  static void ChangeState(object o) {
            MyThreadObject m = o as MyThreadObject;
            while (true)
            {
                lock (m)//向系统申请锁定m对象，如果m对象没有被锁定，那么可以，如果m对象被锁定，那么直到申请到m对象
                {
                    m.ChangeState();//在同一时刻，只有一个线程在执行这个方法
                }//释放对m的锁定
               
            }
        }
       
        static void Main(string[] args)
        {
            MyThreadObject myThreadObject = new MyThreadObject();
            //Task t = new Task(myThreadObject.ChangeState);
            Thread t = new Thread(ChangeState);
            t.Start(myThreadObject);

            new Thread(ChangeState).Start(myThreadObject);

            Console.ReadKey();
        }
    }
}
