using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal
{
    class Bird 
    {
        private string name;
        private string color;

        public Bird()
        {
            this.name = name;
            this.color = color;
        }

        public virtual void Fly() {
            Console.WriteLine("Fly.......");
        }
       
    }
}
