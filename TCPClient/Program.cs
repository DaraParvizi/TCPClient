using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace TCPClient
{
    class Program
    {
        static void Main(string[] args) { 


        TcpClient clientSocket = new TcpClient("localhost", 6789);
        Console.WriteLine("client started");


        NetworkStream ns = clientSocket.GetStream();
        StreamWriter sw = new StreamWriter(ns);
        StreamReader sr = new StreamReader(ns);
        sw.AutoFlush = true;

        while (true)
        {
            Console.WriteLine(sr.ReadLine());
            sw.WriteLine(Console.ReadLine());
        }


        Console.ReadLine();
        ns.Close();
            clientSocket.Close();
        }
    }
}
