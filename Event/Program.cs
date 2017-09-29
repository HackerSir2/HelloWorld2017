using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    class Program
    {
        public delegate void Mydelegate();

        public  event Mydelegate de;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.de = Test01;
            p.de();

            Console.ReadKey();
        }

        static void Test01()
        {
            Console.WriteLine("Test01");
        }
    }
}
