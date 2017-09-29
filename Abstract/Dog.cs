using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract
{
    class Dog : Animal
    {
        public override void move()
        {
            Console.WriteLine("Run Away");
        }
        public override void eat()
        {
            Console.WriteLine("Open the mouth!");
        }
    }
}
