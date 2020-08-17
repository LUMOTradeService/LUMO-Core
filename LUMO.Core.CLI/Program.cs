using LUMO.Core.Clock;
using System;
using System.ComponentModel;

namespace LUMO.Core.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LUMO Clock");
            Console.WriteLine("--------------------------------------------------");
            
            Console.CursorVisible = false;

            ClockManager clockManager = ClockFactory.ClockBasic(true);
            clockManager.OnIntervalElapsed += ClockManager_OnIntervalPassed;
            clockManager.OnTickingStateChanged += ClockManager_OnRunningChange;
            
            Console.SetCursorPosition(0, 4);
            Console.Write("Time Passed(s): ");
            Console.ReadLine();
        }

        private static void ClockManager_OnRunningChange(bool isRunning)
        {
            if (!isRunning)
            {
                Environment.Exit(0);
            }
        }

        private static void ClockManager_OnIntervalPassed(object sender)
        {
            ClockManager clockManager = sender as ClockManager;
            if (clockManager.IsTicking)
            {
                Console.SetCursorPosition(0, 2);
                Console.Write(clockManager.Time);
                Console.SetCursorPosition(16, 4);
                Console.Write(clockManager.TimeElapsed.TotalSeconds);
                if (clockManager.TimeElapsed.TotalSeconds > 10)
                {
                    clockManager.IsTicking = false;
                }
            }
        }
    }
}
