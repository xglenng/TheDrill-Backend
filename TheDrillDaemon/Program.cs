using Nancy.Hosting.Self;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TheDrillDaemon
{
    public class Program
    {
        static void Main(string[] args)
        {
            NancyHost host = new NancyHost(new Uri("http://localhost:8080"));
            host.Start();

            //Loop indefinitely
            while (true) { };
        }
    }
}
