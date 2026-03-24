using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();
            
            crono1.Start();
            Thread.Sleep(500);
            
            crono2.Start();
            Thread.Sleep(250);
            
            crono1.Stop();
            crono2.Stop();

            TimeSpan crono1_elapsedTime = crono1.Elapsed;
            TimeSpan crono2_elapsedTime = crono2.Elapsed;

            double elapsedTime1 = crono1_elapsedTime.TotalMilliseconds  / 1000;
            double elapsedTime2 = crono2_elapsedTime.TotalMilliseconds  / 1000;

            Console.WriteLine($"crono1 {elapsedTime1:f4}");
            Console.WriteLine($"crono2 {elapsedTime2:f4}");
        }
    }
}
