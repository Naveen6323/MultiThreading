using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    using System;
    using System.Threading;

    class LOCK
    {
        static object lockObj = new object();

        public static void PrintNumbers()
        {
            lock (lockObj)
            {
                for (int i = 1; i <= 3; i++)
                {
                    Console.WriteLine($"Locked Thread: {i}");
                    Thread.Sleep(500);
                }
            }
        }
    }

            

}
