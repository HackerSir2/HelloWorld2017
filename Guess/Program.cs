using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int num = random.Next(0,51);
            while (true)
            {
                Console.WriteLine("请您输入一个0-50之间的数：");
                int temp= Convert.ToInt32(Console.ReadLine());
                if (temp<num)
                {
                    Console.WriteLine("您猜小了，这个数字比{0}大",temp);
                }
                else if (temp>num)
                {
                    Console.WriteLine("您猜大了，这个数字比{0}小",temp);
                }
                else
                {
                    Console.WriteLine("恭喜您猜对了，这个数字为：{0}",num);
                    break;
                }
            }
            Console.ReadLine();
        }
    }
}
