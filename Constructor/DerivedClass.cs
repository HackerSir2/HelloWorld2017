using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class DerivedClass:BaseClass
    {
        private int y;

        public DerivedClass()/*:base()*/ {
            Console.WriteLine("调用DerivedClass的构造函数");
        }
        public DerivedClass(int x,int y):base(x) {
            this.y = y;

            Console.WriteLine("调用子类带参的构造函数");
        }
    }
}
