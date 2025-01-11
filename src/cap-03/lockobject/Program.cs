namespace lockobject;
internal static class Program
{
    private static readonly Lock _lock = new();
    private static readonly string filePath = "output.txt";

    static void Main(string[] args)
    {
        File.WriteAllText(filePath, string.Empty);

        var thread1 = new Thread(() => WriteToFile("Hilo 1", 10));
        var thread2 = new Thread(() => WriteToFile("Hilo 2", 10));
        var thread3 = new Thread(() => WriteToFile("Hilo 3", 10));

        thread1.Start();
        thread2.Start();
        thread3.Start();

        thread1.Join();
        thread2.Join();
        thread3.Join();

        Console.WriteLine("Proceso finalizado.");
    }

    static void WriteToFile(string threadName, int lines)
    {
        for (int i = 1; i <= lines; i++)
        {
            using (_lock.EnterScope())
            {
                using StreamWriter writer = new(filePath, append: true);
                string message = $"{DateTime.Now:HH:mm:ss} {threadName}: Línea {i}";
                writer.WriteLine(message);
                Console.WriteLine(message);
            }
            

            Thread.Sleep(Random.Shared.Next(50, 500));
        }
    }
}