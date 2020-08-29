using System;
using System.Threading;
using StopWatch2;

namespace StopWatch2
{
    class Program
    {
        static void Main(string[] args)
        {

            StopWatch stopWatch = new StopWatch();

            stopWatch.Start();

            Random random = new Random();       //random wait time...upto 7 seconds
            int wait = random.Next(7);
            Thread.Sleep(wait * 1000);

            stopWatch.Stop();

            Console.WriteLine("Interval: " + stopWatch.TimeInterval());
            Console.ReadKey();
        }

    }
}
