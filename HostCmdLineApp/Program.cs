﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HostCmdLineApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = 
                new ServiceHost(typeof(HelloWorldService.HelloWorldService),
                new Uri("http://localhost:55856/HostCmdLineApp/HelloWordService.svc"));
            host.Open();
            Console.WriteLine("Hello World Service is running");
            Console.WriteLine("Press any key to stop it....");
            Console.ReadKey();
            host.Close();

        }
    }
}
