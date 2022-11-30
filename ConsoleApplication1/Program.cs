using System;
using System.Diagnostics;
using static ClassLibrary1.MyStopwatch;

namespace StopWatchSample
{
    class OperationsTimer
    {
        public static void Main()
        {
            DisplayTimerProperties();

            Console.WriteLine();
            Console.WriteLine("Press the Enter key to begin:");
            Console.ReadLine();
            Console.WriteLine();
            TimeOperations();
        }
    }
}