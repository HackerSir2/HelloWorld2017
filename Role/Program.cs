using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Role
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "siki";
            //string str1 = "abcdefg.\\*hijklmn";
            //int hp = 100;
            //int level =32;
            //float exp = 3000.0f;

            //string str1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(str1);
            //Console.WriteLine(num1);

            //string str2 = Console.ReadLine();
            //double num2 = Convert.ToDouble(str2);
            //Console.WriteLine(num2);
            Console.WriteLine("请输入第一个数字：");
            string str1 = Console.ReadLine();
            //int num1 = Convert.ToInt32(str1);
            Console.WriteLine("请输入第二个数字：");
            string str2 = Console.ReadLine();
            //int num2 = Convert.ToInt32(str2);
            Console.WriteLine("{0}和{1}的和为{2}：",Convert.ToInt32(str1),
                Convert.ToInt32(str2),Convert.ToInt32(str1)+Convert.ToInt32(str2));


            Console.ReadKey();


        }
    }
}
