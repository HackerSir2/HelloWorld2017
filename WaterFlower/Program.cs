using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//水仙花数
namespace WaterFlower
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 100; i < 1000; i++)
            {
                int units = i % 10;  //个位
                int tens = i / 10 % 10; //十位
                int hundreds = i / 100; //百位
                int NewNumber = Convert.ToInt32(Math.Pow(hundreds, 3) + Math.Pow(tens, 3) + Math.Pow(units, 3));
                if (NewNumber==i)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadKey();
        }
    }
}
