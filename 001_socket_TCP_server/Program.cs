using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace _001_socket_TCP_server
{
    class Program
    {
        //服务器端
        static void Main(string[] args)
        {

            //创建服务器端的socket
            Socket tcpServerSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //2.绑定IP端口号 ip地址：192.168.1.105
            IPAddress ipadress = IPAddress.Parse("192.168.1.114"); ;//ip地址对象
            EndPoint point = new IPEndPoint(ipadress, 6666); //封装了ip地址和端口-标识网络地址
            tcpServerSocket.Bind(point);//向操作系统申请一个可用的端口号，用来做通信
            //开始监听（等待客户端连接）
            tcpServerSocket.Listen(100);//最大连接数为100

            Socket clientSocket = tcpServerSocket.Accept();//接收客户端的连接

            #region 服务器端发送消息
            string message = "hello world!";
            byte[] data = Encoding.UTF8.GetBytes(message); //将message转化为Byte[] 数组
            clientSocket.Send(data);

            #endregion

            #region 服务器端接收消息
            byte[] data2 = new byte[1024];
            //int length = tcpServerSocket.Receive(data2);
            string message2 = Encoding.UTF8.GetString(data2, 0, clientSocket.Receive(data2));
            Console.WriteLine($"收到来自客户端的一条消息：{message2}");
            
            #endregion


            Console.ReadKey();
        }
    }
}
