using System;
using System.Threading.Tasks;

namespace AsyncAwaitDemo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            SayHello();
            SayBye();
        }

        public static async Task SayHello()
        {
            await Task.Run(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Hello");
                    Task.Delay(100).Wait();
                }
            });
        }

        public static void SayBye()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Bye");
                Task.Delay(100).Wait();
            }
        }
    }
}