using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String01
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "www.baidu.com";
            int l = str.Length;
            //Console.WriteLine(l);

            //for (int i = 0; i<str.Length; i++)
            //{
            //Console.Write(str[i]+" ");

           string [] array= str.Split('.');
            //foreach (var temp in str)
            //{
                //Console.Write(temp+" ");
            //}
            for (int i = 0; i <array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("#############");
            int a = str.CompareTo("www.badu.com");
            char[] ch = new[] {'a','c','e' };
            string  str1=str.Substring(4,5);//从指定位置开始截取字符串
            string str2 = str.Trim();
            string str3 = str.ToLower();
            string str4 = str.ToUpper();
            int b = str.IndexOf("baidu");
            int c = str.IndexOfAny(ch,0);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(str.Contains(' '));
            StringBuilder sb = new StringBuilder("www.hao123.com");
            //for (int i = 0; i < sb.Length; i++)
            //{
            //    Console.WriteLine(sb[i]);
            //}
            sb.Append("happy");
            sb.Insert(0,"http://");
            sb.Remove(0,7);
            sb.Replace("happy"," ");
            sb.Replace(".","-");
            string str5 = sb.ToString();
            string str6 = "www.baidu.com /n devsiki.cn";
            Console.WriteLine(str6);
            Console.WriteLine(sb);
            Console.WriteLine(str5);
            Console.ReadKey();

        }
    }
}
