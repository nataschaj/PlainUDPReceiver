using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

namespace PlainUDPReceiver
{
    class UDPReceiver
    {
        private readonly int PORT;

        public UDPReceiver(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            //Modtage
            byte[] buffer = new byte[2048];

            UdpClient udp = new UdpClient(PORT);
            IPEndPoint senderEP = new IPEndPoint(IPAddress.Any, 0);

            buffer = udp.Receive(ref senderEP);
            Console.WriteLine($"UDP datagram received lgt={buffer.Length}");
            Console.WriteLine($"Afsender: {senderEP.Address}, port: {senderEP.Port}");

            //Her converter vi byte til string
            String incommingString = Encoding.ASCII.GetString(buffer);
            Console.WriteLine(incommingString);

            //Sender
            String outgoingString = incommingString.ToUpper(); //sætter outgoing string til uppercase
            byte[] outBuffer = Encoding.ASCII.GetBytes(outgoingString);

            udp.Send(outBuffer, outBuffer.Length, senderEP);


        }
    }
}
