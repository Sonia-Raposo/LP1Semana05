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


        }
    }
}
