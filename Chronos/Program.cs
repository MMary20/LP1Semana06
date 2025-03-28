using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();
            Stopwatch crono2 = new Stopwatch();

            crono1.Start();
            Thread.Sleep(500); 
            crono1.Stop();

            crono2.Start();
            Thread.Sleep(250);
            crono2.Stop();


            Console.WriteLine($"{crono1.ElapsedMilliseconds / 1000.0}");
            Console.WriteLine($"{crono2.ElapsedMilliseconds / 1000.0}");

            Console.ReadKey();
        }
    }
}



