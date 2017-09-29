using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Virtual
{
    class Enemy
    {
        private float speed;
        private float hp;

        public Enemy()
        {
            this.speed = speed;
            this.hp = hp;
        }
        //虚方法的定义
        public virtual void Move() {
            Console.WriteLine("移动速度是：{0}", speed);
        }
        public void BloodCount() {
            Console.WriteLine("当前血量剩余：{0}",hp);
        }

    }
}
