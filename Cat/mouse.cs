using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cat
{
    class Mouse
    {
        private string name;
        private string color;

        public Mouse(string name,string color,Cat cat)
        {
            this.name = name;
            this.color = color;
            cat.catCome += this.runAway; //将自身的方法注册进“猫”里，订阅了一个消息
        }

        public void runAway()
        {
            Console.WriteLine(color+"的"+name+"赶紧跑！");
        }
    }
}
