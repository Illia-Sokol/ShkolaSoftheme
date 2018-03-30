using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;

namespace PLINQ_DEMO
{
    class Program
    {
        static void Main()
        {
            ParallelPing();

            Console.ReadKey();
        }

        static void ParallelPing()
        {
            List<string> sites = new List<string>{ "www.yahoo.com",
                                                   "www.google.com",
                                                   "www.aspsnippets.com" };

            List<PingReply> pingReplies = (from site in sites.AsParallel().WithDegreeOfParallelism(sites.Count)
                                           select DoPing(site)).ToList() as List<PingReply>;

            foreach (var s in pingReplies)
            {
                Console.WriteLine(s.Address + " -> Time, ms:" + s.RoundtripTime + " -> Status: " + s.Status);
            }
        }


        static PingReply DoPing(string site)
        {
            Ping p = new Ping();
            return p.Send(site);
        }
    }
}
