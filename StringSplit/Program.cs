using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入字符串：");
            string str = Console.ReadLine();
            string[] stringArray = str.Split(' ');
            int[] numStr = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
               int temp= Convert.ToInt32(stringArray[i]);
                numStr[i] = temp;
            }
            foreach (int temp in numStr)
            {
                Console.Write(temp);
            }
            //    foreach (string  temp in stringArray)
            //    {
            //        Console.WriteLine(temp);
            //    }

            Console.ReadKey();
        }
    }

}
