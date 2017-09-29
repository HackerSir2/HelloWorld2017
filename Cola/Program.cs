using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cola
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumCola = 364;
            int numEmpty = sumCola;
            int newCola;
            while (numEmpty>=3)
            {
                newCola = numEmpty / 3;  //每次兑换的可乐数
                sumCola += newCola; 
                numEmpty = numEmpty % 3+newCola;   //每次兑换完后空瓶子的数量
            }
            Console.WriteLine("总共可以喝{0}瓶可乐，还剩下{1}个空瓶子", sumCola, numEmpty);
            Console.ReadKey();
            }
        }
    }

