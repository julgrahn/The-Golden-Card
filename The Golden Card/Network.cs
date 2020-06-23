using System.Net;
using System.Net.Sockets;
using System;

namespace The_Golden_Card
{
    public class Network
    {
        TcpListener server = null;
        TcpClient client = new TcpClient(); //Anslutning mellan klient NOS_Export och server som är vårt program
        Int32 port = 12345;
        IPAddress localAddress = IPAddress.Parse("127.0.0.1");

        public Network()
        {
            server = new TcpListener(localAddress, port);
        }

    }
}
