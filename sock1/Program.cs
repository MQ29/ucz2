//(C) Michal Turek
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Klient
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                IPAddress ip = host.AddressList[0];
                IPEndPoint handler = new IPEndPoint(ip, 2000);
                Socket socket = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                socket.Connect(handler);
                Console.WriteLine("Connected ", socket.RemoteEndPoint.ToString());
                byte[] buffer = Encoding.ASCII.GetBytes("Test.");
                int count = socket.Send(buffer);
                byte[] result = new byte[2048];
                int count2 = socket.Receive(result);
                Console.WriteLine("Reply from server: " + Encoding.ASCII.GetString(result, 0, count2));
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.In.ReadLine();
        }
    }
}
