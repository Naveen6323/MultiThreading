
class Program
{
    static void PrintNumbers()
    {
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"Thread: {i}");
            Thread.Sleep(1000);  
        }
    }

    static void Main()
    {
        Thread thread = new Thread(PrintNumbers);
        thread.Start();  

        Console.WriteLine("Main thread continues...");
    }
}
