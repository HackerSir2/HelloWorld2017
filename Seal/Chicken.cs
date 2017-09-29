using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seal
{
    class Chicken:Bird
    {
        public sealed override void Fly()
        {
            //base.Fly();//调用父类的虚方法
            Console.WriteLine("The Chicken is fly.....");
        }
    }
}
