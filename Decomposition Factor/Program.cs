using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decomposition_Factor
{
    class Program
    {
        public static void Decomposition_Factor(int values)
        {

            for (int i = 2; i <Math.Sqrt(values); i++)
            {
                if (values % i == 0)                                                                                                      
                {
                    Console.WriteLine(i);
                    i++;
                }

            }

        }
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个要求质因数的正整数：");
            int n = Convert.ToInt32(Console.ReadLine());
            Decomposition_Factor(n);

            Console.ReadKey();
        }
    }
}
