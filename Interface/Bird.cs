using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class Bird : IFly, ISpeed  //一个类可以实现多个接口
    {
        public void fly()
        {
            
        }

        public void speedFly()
        {
          
        }
    }
}
