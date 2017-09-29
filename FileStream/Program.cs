using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream01
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.创建文件流，用于操作文件 文件流常用来读取非文本文件
            //FileStream stream = new FileStream("TextFile1.txt", FileMode.Open);
            //2.读取或者写入数据
            //byte[] data = new byte[1024];
            //while (true)
            //{
            //    int length = stream.Read(data,0,data.Length);
            //    if (0==length)
            //    {
            //        Console.WriteLine($"文件读取结束");
            //        break;
            //    }
            //    for (int i = 0; i < data.Length; i++)
            //    {
            //        Console.Write(data[i] + $" ");
            //    }
            //}
            //文件的复制
            //FileStream readStream = new FileStream("3.LINQ.png", FileMode.Open);//读取数据流
            //FileStream writeStream = new FileStream("4.LINQ.jpg", FileMode.Create);//写入数据流
            //byte[] data = new byte[1024];

            //while (true)
            //{
            //    //读取数据并存储在data数组中
            //    int length = readStream.Read(data, 0, data.Length);
            //    if (length == 0)
            //    {
            //        Console.WriteLine($"读取结束");
            //        break;
            //    }
            //    else
            //    {
            //        writeStream.Write(data,0,length);
            //    }
            //}
            //readStream.Close();
            //writeStream.Close();
            FileStream fileStream = new FileStream("3.LINQ.png",FileMode.Open);
            FileStream writeStream = new FileStream("5.LINQ.png",FileMode.Create);
            byte[] data = new byte[1024];
            while (true)
            {
                int length = fileStream.Read(data,0,data.Length);
                if (0==length)
                {
                    Console.WriteLine($"文件写入结束！");
                    break;
                }
                else
                {
                    //将文件写入5.LINQ.png中
                    writeStream.Write(data,0,length);
                }    
            }
            fileStream.Close();
            writeStream.Close();

            
            Console.ReadKey();
        }
    }
}
