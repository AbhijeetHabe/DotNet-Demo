namespace Threading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread mainThread = Thread.CurrentThread;
            mainThread.Name = "main thread";
            Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => CountDown("timer #1"));
            Thread thread2 = new Thread(() => CountUp("timer #2"));
            thread1.Start();
            thread2.Start();

            //CountDown();
            //CountUp();
        }

        public static void CountDown(string name)
        {
            for (int i = 10; i>=0; i--)
            {
                Console.WriteLine($"{name}: "+i+" seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} is complete");
        }

        public static void CountUp(string name)
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{name}: " + i + " seconds");
                Thread.Sleep(1000);
            }
            Console.WriteLine($"{name} is complete");
        }
    }
}