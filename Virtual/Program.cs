using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Program
    {
        static void Main(string[] args)
        {
            //Boss b = new Boss();
            //b.Move();
            //b.BloodCount();
            //Enemy e = new Boss();
            ////Boss b = (Boss)e;
            //e.Move();
            //Enemy e = new Enemy();
            //Boss b=(Boss)e;
            //b.Move();
            Enemy enemy = new Enemy();
            enemy.Move();

            Console.ReadKey();

        }
    }
}
