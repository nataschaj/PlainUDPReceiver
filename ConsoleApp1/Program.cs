﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlainUDPSender
{
    class Program
    {
        private const int PORT = 7007;
        static void Main(string[] args)
        {
            UDPSender udpsend = new UDPSender(PORT);
            udpsend.Start();
            Console.ReadLine();
        }
    }
}
