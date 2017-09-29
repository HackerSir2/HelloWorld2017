using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 100 / 5; i++)
            {
                for (int j = 0; j<= (100 - 5 * i) / 3; j++)
                {
                    int remainMoney = 100 - i * 5 - j * 3;
                    int numberChick = remainMoney * 3;
                    if ((i+j+numberChick)==100)
                    {
                        Console.WriteLine("公鸡：{0}只，母鸡：{1}只，小鸡：{2}只",i,j,numberChick);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
