﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPReceiver
{
    class Program
    {
        private const int PORT = 7007;
        static void Main(string[] args)
        {
            UDPReceiver udpmodtager = new UDPReceiver(PORT);
            udpmodtager.Start();
            Console.ReadLine();
        }
    }
}
