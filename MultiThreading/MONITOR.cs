using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    class MONITOR
    {
        static object lockObj = new object();

        public static void PrintNumbers()
        {
            Monitor.Enter(lockObj);
            try
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Monitor Thread: {i}");
                    Thread.Sleep(500);
                }
            }
            finally
            {
                Monitor.Exit(lockObj);
            }
        }

    }
}
