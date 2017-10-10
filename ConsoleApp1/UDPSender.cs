using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PlainUDPSender
{

    class UDPSender
    {
        private readonly int PORT;

        public UDPSender(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            String sendstring = "Natascha";
            byte[] buffer = Encoding.ASCII.GetBytes(sendstring);

            UdpClient udp = new UdpClient();

            IPEndPoint endpoint = new IPEndPoint(IPAddress.Broadcast, PORT);
            udp.Send(buffer, buffer.Length, endpoint);

            IPEndPoint receiverEP = new IPEndPoint(IPAddress.Any, 0);
            byte[] receivebuffer = udp.Receive(ref receiverEP);
            Console.WriteLine($"UDP datagram received length={receivebuffer.Length}");
            String incommingStr = Encoding.ASCII.GetString(receivebuffer);
            Console.WriteLine(incommingStr);

        }
    }
}
