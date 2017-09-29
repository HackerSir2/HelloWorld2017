using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_ReadFile
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] str = File.ReadAllLines("TextFile1.txt");
            //byte[] data = File.ReadAllBytes("TextFile1.txt");
            //string str = File.ReadAllText("TextFile1.txt");
            //foreach (var temp in str)
            //{
            //    Console.WriteLine(temp);
            //}
            //Console.WriteLine(str);
            //byte[] data=File.ReadAllBytes("3.LINQ.png");
            //foreach (var temp in data)
            //{
            //    Console.Write(temp);
            //}
            File.WriteAllText("Txt2.txt","中国");//直接读入字符串
            File.WriteAllLines("Txt3.txt", new string[] { "nfa;k", "jpfoaip","中国" });//读入字符串数组
            //byte[] data = Encoding.UTF8.GetBytes("happy new year");
            byte[] data = File.ReadAllBytes("3.LINQ.png");
            File.WriteAllBytes("4.jpg",data);//写入字节

            Console.ReadKey();
        }
    }
}
