﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client.ServiceReference1;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            ATMMonitorClient client = new ATMMonitorClient();
            Console.WriteLine(client.GetReport());
            Console.Read();
        }
    }
}
