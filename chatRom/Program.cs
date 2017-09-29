using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace chatRom
{
    class Program
    {
        
        static List<Client> clientList = new List<Client>();
        static void Main(string[] args)
        {
            Socket tcpServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ipaddress = IPAddress.Parse("192.168.1.100");
            EndPoint point = new IPEndPoint(ipaddress,7788);
            tcpServer.Bind(point);
            tcpServer.Listen(100);
            Console.WriteLine("Server is runing......");

            while (true)
            {
                Socket clientSocket = tcpServer.Accept();
                Console.WriteLine("a client is connected!");
                Client client = new Client(clientSocket);
                clientList.Add(client);
            }


        }
    }
}
