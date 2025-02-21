using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    using System;
    using System.Threading.Tasks;

    class PARALLEL
    {
        public static void Example()
        {
            //Parallel.For(1, 6, i =>
            //{
            //    Console.WriteLine($"Parallel Task: {i}");
            //    Task.Delay(500).Wait();
            //});

            Console.WriteLine("Main thread continues...");
            Parallel.ForEach(new List<int> { 1, 2, 3, 4, 5 }, i =>
            {
                Console.WriteLine($"Parallel Task: {i}");
                Task.Delay(500).Wait();
            });
        }
    }

}
