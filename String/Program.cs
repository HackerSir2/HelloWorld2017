using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " www.HAPPY.com ";
            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }
            string res = str.ToLower();
            string res1 = str.ToUpper();
            string res2 = str.Trim();
            string [] res3=str.Split('.');
            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.WriteLine(res2);
            foreach (string temp in res3)
            {
                Console.WriteLine(temp);
            }
            Console.ReadKey();
        }
    }
}
