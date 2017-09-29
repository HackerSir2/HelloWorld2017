using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Cat
    {
        private string name;
        private string color;

        public Cat(string name,string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Catcomming()
        {
            Console.WriteLine("一只"+color+"name"+"来了！");
            if (catCome!=null)
            {
                catCome();
            }
        }

        public event Action catCome; //声明了一个事件，发布了一个消息
    }
}
