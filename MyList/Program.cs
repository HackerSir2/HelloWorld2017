using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>(); //泛型类的声明与构造
            myList.Add(24);
            myList.Add(124);
            myList.Add(585);
            myList.Add(323);
            myList[1] = 100; //索引器的调用
            myList.Insert(2, 9);
            myList.removeAt(3);
            myList.Sort();
            for (int i = 0; i < myList.getCount; i++)
            {
                Console.Write(myList[i]+" ");
            }
            Console.WriteLine("***********");
            Console.WriteLine(myList.IndexOf(323));
            //Console.WriteLine(myList[3]);
            Console.ReadKey();
        }
    }
}
