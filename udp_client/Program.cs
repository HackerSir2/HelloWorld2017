using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace udp_client
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpClient = new UdpClient(new IPEndPoint(IPAddress.Parse("192.168.1.114"),7788));
            //循环接收消息
            while (true)
            {
                IPEndPoint point = new IPEndPoint(IPAddress.Any, 0);
                byte[] data = udpClient.Receive(ref point);
                string message = Encoding.UTF8.GetString(data, 0, data.Length);

                Console.WriteLine($"接收到了消息：" + message);
                if (message.Equals("exit"))
                    break;
            }

            udpClient.Close();
            Console.ReadKey();
        }
    }
}
