using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading
{
    class TASK
    {
        public static async Task PrintNumbersAsync()
        {
            //await Task.Run(() =>
            //{
            //    for (int i = 1; i <= 5; i++)
            //    {
            //        Console.WriteLine($"Task Thread: {i}");
            //        Task.Delay(1000).Wait();
            //    }
            //});

            for (int i = 1; i <= 5; i++)
            {
                  await Task.Delay(1000);

                Console.WriteLine($"Task Thread: {i}");
                //Task.Delay(1000).Wait();
            }

        }



    }

}
