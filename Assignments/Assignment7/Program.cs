namespace Assignment7
{
    internal class Program
    {
        // Example of Async Await
        static async Task Main1()
        {
            Console.WriteLine("Do work before");
            string message = DoWork();  //sync call-same thread,waiting call, blocking call
            //string message = await DoWorkAsync();  //async call,waiting call, non blocking call
            Console.WriteLine("Do work after");
            Console.WriteLine(message);
        }
        static async Task<string> DoWorkAsync()
        {
            return await Task.Run(() =>
            {
                Thread.Sleep(5000);
                return "Task Done";
            });
        }
        static string DoWork()
        {
            Thread.Sleep(5000);
            return "Work Done";
        }
        static async Task Main()
        {
            Console.WriteLine("Before");
            Task<Task<String>> t1 = new Task<Task<string>>(DoWorkAsync);
            t1.Start();
            Console.WriteLine("After");
            string message = await t1.Result;
            Console.WriteLine(message);
        }
    }
}