
using MultiThreading;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.SpinWait(5000);
        }
    }

    static async Task Main()
    {
        //Thread thread = new Thread(PrintNumbers);
        //thread.Start();

        //Console.WriteLine("Main thread continues...");

        //ThreadPool.QueueUserWorkItem(ThreadPoolExample.PrintNumbers);
        //Console.WriteLine("Main thread continues...");
        //Thread.Sleep(1000);

        //Thread t1 = new Thread(LOCK.PrintNumbers);
        //Thread t2 = new Thread(LOCK.PrintNumbers);

        //t1.Start();
        //t2.Start();

        //Task task = TASK.PrintNumbersAsync();
        //Console.WriteLine("Main thread continues...");
        ////await TASK.PrintNumbersAsync();
        //Task task = Task.Run(() =>
        //{
        //    for (int i = 1; i <= 5; i++)
        //    {
        //        Console.WriteLine($"Task Thread: {i}");
        //        Task.Delay(1000);
        //    }
        //});
        //Task task1 = Task.Run(() =>
        //{
        //    Console.WriteLine("hello");
        //});
        //await Task.WhenAll(task, task1);

        //MONITOR.PrintNumbers();

        //PARALLEL.Example();
    }


}



