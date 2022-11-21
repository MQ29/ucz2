//(C) Michal Turek
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
namespace Serwer
{
    class Program
    {
        static void Main(string[] args)
        {
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            IPAddress ip = host.AddressList[0];
            IPEndPoint handler = new IPEndPoint(ip, 2000);
            Socket socket = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                socket.Bind(handler);
                socket.Listen(20);  // max. liczba oczekujšcych
                Console.WriteLine("Ready.");
                while (true)
                {
                    Socket clientSocket = socket.Accept();
                    byte[] buffer = new Byte[2048];
                    string data = null;
                    while (true)
                    { // czytamy do pierwszej kropki
                        int count = clientSocket.Receive(buffer);
                        data += Encoding.ASCII.GetString(buffer, 0, count);
                        if (data.IndexOf(".") > -1) break;
                    }
                    Console.WriteLine("Data from client: " + data);
                    byte[] result = Encoding.ASCII.GetBytes("Test");
                    clientSocket.Send(result);  // echo
                    clientSocket.Shutdown(SocketShutdown.Both);
                    clientSocket.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}