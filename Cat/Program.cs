using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Kaff", "yellow");
            Mouse mouse1 = new Mouse("Miqi", "black",cat);
            Mouse mouse2 = new Mouse("Tike", "white",cat);
            Mouse mouse3 = new Mouse("Maria", "red",cat);

            //cat.catCome += mouse1.runAway;
            //cat.catCome += mouse2.runAway;
            //cat.catCome += mouse3.runAway;
            cat.Catcomming();
            //cat.catCome(); //事件不能在外部触发，只能在类的内部触发，但可在外部注册


            Console.ReadKey();
        }
    }
}
