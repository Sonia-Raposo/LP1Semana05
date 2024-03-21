using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 = new Stopwatch();

            Stopwatch crono2 = new Stopwatch();


            //Crono 1 Start
            crono1.Start();

            //Crono 1 Sleep 0.6s
            Thread.Sleep(600);


            //Crono 2 Start
            crono2.Start();

            //Crono 2 Sleep 0.2s
            Thread.Sleep(200);

            //Stop cronos
            crono1.Stop();
            crono2.Stop();

            //Crono 1 and 2 time ellapsed in s
            float timer1 = crono1.ElapsedMilliseconds / 1000f;
            float timer2 = crono2.ElapsedMilliseconds / 1000f;


            //Print time of Crono 1 and 2 with 3 decimals
            Console.WriteLine($"Crono 1: {timer1:f3}");
            Console.WriteLine($"Crono 2: {timer2:f3}");


        }
    }
}
