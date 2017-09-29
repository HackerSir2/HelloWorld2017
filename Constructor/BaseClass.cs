using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class BaseClass
    {
       private int x;

        public BaseClass() {
            Console.WriteLine("调用BaseClass构造函数");
        }
        public BaseClass(int x) {
            this.x = x; 

            Console.WriteLine("调用父类带参的构造函数");
        }
    }
}
