using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace chatRom
{
    class Client
    {
        private Socket clientSocket;
        private Thread t;
        private byte[] data = new byte[1024];


        public Client(Socket s)
        {
            clientSocket = s;
            t = new Thread(ReceiveMessage);//
            t.Start();
        }

        private void ReceiveMessage()
        {
            while (true)
            {
                //判断客户端连接是否断开
                if (clientSocket.Connected==false)
                {
                    break;
                }
                int length = clientSocket.Receive(data);
                string message = Encoding.UTF8.GetString(data,0,length);
                Console.WriteLine("收到了消息："+message);
            }
        }
    }
}
