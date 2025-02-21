using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    using System;
    using System.Threading;

    class ThreadPoolExample
    {
        public static void PrintNumbers(object state)
        {
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"ThreadPool Task: {i}");
                Thread.Sleep(500);
            }
        }

        
    }

}
