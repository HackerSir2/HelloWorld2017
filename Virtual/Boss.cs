using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Boss:Enemy
    {
        public override void Move()
        {
            Console.WriteLine("Boss移动");
        }
    }
}
