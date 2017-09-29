using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamReader01
{
    class Program
    {
        static void Main(string[] args)
        {
            //StreamReader reader = new StreamReader("TextFile1.txt");
            //while (true)
            //{
            //    string str = reader.ReadLine();
            //    if (str == null)
            //        break;
            //    Console.WriteLine(str);
            //}

            //string str2=reader.ReadToEnd();
            //Console.WriteLine(str2);
            //while (true)
            //{
            //    int res = reader.Read();
            //    if (-1 == res)
            //        break;
            //    Console.Write((char)res);
            //}
            //reader.Close();

            //写入文件
            StreamWriter writer = new StreamWriter("TextFile2.txt");
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "q")
                    break;
                //writer.Write(str);
                writer.WriteLine(str);
            }

            writer.Close();
            Console.ReadKey();
        }
    }
}
