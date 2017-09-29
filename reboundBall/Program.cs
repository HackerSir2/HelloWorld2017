using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reboundBall
{
    class Program
    {
        static double Fac(int n)
        {
            if (1 == n) return 1;
            return n * Fac(n - 1);
        }
        static void Main(string[] args)
        {
            int sum = 0;
            int k = 0;
            while (sum<2000)
            {
                k++;
                sum += k * k;
            }
            Console.WriteLine(k-1);
            Console.WriteLine("==============");
            float height = 100;
            float distance = 0;
            for (int i = 1; i <= 10; i++)
            {
                distance += height;
                height /= 2;
            }

            Console.WriteLine("第十次落地时，共经过{0}米，第十次反弹的高度为：{1}", distance, height);
            Console.WriteLine(Fac(6));

            double number = Convert.ToDouble(Console.ReadLine());
            //int numberInteger = (int)(number / 1);
            //double num = number - numberInteger;
            //if (num >= 0.5f)
            //{
            //    numberInteger++;
            //}
            //Console.WriteLine(numberInteger);
            int res = (int)(number+0.5f);
            Console.WriteLine(res);

            Console.ReadKey();
        }
    }
}
