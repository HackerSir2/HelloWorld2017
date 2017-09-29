using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            //绝对路径:加上文件完整的路径名
            //FileInfo fileInfo = new FileInfo("TextFile1.txt");
            //FileInfo fileInfo = new FileInfo(@"F:\C#code\HelloWorld2017\File\bin\Debug\TextFile1.txt");
            ////属性1：判断该属性是否存在
            //Console.WriteLine(fileInfo.Exists);
            //Console.WriteLine(fileInfo.Name);
            //Console.WriteLine(fileInfo.Directory);//取得文件所在的路径
            //Console.WriteLine(fileInfo.IsReadOnly);
            ////fileInfo.Delete();
            //fileInfo.CopyTo("hekll");
            //FileInfo fileInfo = new FileInfo("siki.txt");
            //if (fileInfo.Exists==false)
            //{
            //    fileInfo.Create();
            //}

            //fileInfo.MoveTo("siki2.txt");//重命名操作
            //按照绝对路径创建文件夹
            //DirectoryInfo dirInfo = new DirectoryInfo(@"F:\C#code\HelloWorld2017\File\bin\Debug");
            //Console.WriteLine(dirInfo.Exists);
            //Console.WriteLine(dirInfo.Name);
            //Console.WriteLine(dirInfo.Parent);
            //Console.WriteLine(dirInfo.Root);
            //Console.WriteLine(dirInfo.CreateSubdirectory("siki"));
            //Console.WriteLine(dirInfo.CreationTime);

            //绝对路径创建文件夹
            DirectoryInfo dirInfo = new DirectoryInfo("manu");
            if (dirInfo.Exists==false)
            {
                dirInfo.Create();
            }
            
            Console.ReadKey();
        }
    }
}
