using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Thread01
{
    class MyThread
    {
        private string filePath;
        private string fileName;

        public MyThread(string filePath,string fileName)
        {
            this.fileName = fileName;
            this.filePath = filePath;
        }

        public void DownloadFile()
        {
            Console.WriteLine("开始下载"+filePath+" "+fileName);
            Thread.Sleep(1000);
            Console.WriteLine("下载完成");
        }


    }
}
