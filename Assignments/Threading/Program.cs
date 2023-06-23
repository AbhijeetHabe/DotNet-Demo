namespace Threading
{
    internal class Program
    {
        static void Main1(string[] args)
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
        static void Main()
        {
            Task<int> task1 = new Task<int>(CountDown, "task #1");
            Task<int> task2 = new Task<int>(CountUp, "task #2");

            task1.Start();
            task2.Start();

            if (!task1.IsCompleted) 
            {
                task1.Wait();
            }
            if (!task2.IsCompleted)
            {
                task2.Wait();
            }
            Console.WriteLine(task1.Result);
            Console.WriteLine(task2.Result);
        }

        public static int CountDown(object name)
        {
            int i;
            for (i = 100; i>0; i--)
            {
                Console.WriteLine($"{name}: "+i+" seconds");
                //Thread.Sleep(500);
            }
            Console.WriteLine($"{name} is complete");
            return i;
        }

        public static int CountUp(object name)
        {
            int i;
            for (i = 0; i < 100; i++)
            {
                Console.WriteLine($"{name}: " + i + " seconds");
                //Thread.Sleep(500);
            }
            Console.WriteLine($"{name} is complete");
            return i;
        }
    }
}