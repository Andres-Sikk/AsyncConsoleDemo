using System;
using System.Threading.Tasks;

namespace AsyncConsoleDemo
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int amount = 10;
            await Print(amount);
        }
        public static async Task Print(int amount)
        {
            Console.WriteLine("Press Esc to stop...");
            bool yesorno = true;
            await Interupt(yesorno);
            while (yesorno && amount > 0)
            {
                Console.WriteLine(amount);
                await Task.Delay(1000);
                amount -= 1;
            }
        }
        public static async Task Interupt(bool yesorno)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            if (key.Key == ConsoleKey.Escape)
            {
                yesorno = false;
                Console.WriteLine("Stop");
            }
        }
    }
}
