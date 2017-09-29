using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要加密的字符串：");
            string str = Console.ReadLine();
            string str1 = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z'|| str[i] >= 'A' && str[i] <= 'Z')
                {
                    int num=str[i];
                    char temp= Convert.ToChar(num+3);
                    str1+= temp;
                }
                else
                {
                    str1 += str[i];    
                }
            }
            //foreach (char temp in ch)
            //{
            //    Console.Write(temp);
            //}

            Console.ReadKey();
        }
    }
}
