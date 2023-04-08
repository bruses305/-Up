using System;

namespace git
{
    class Program
    {
        static void Main(string[] args)
        {
            for(;;)
            {
                Console.SetCursorPosition(10, 2);
                Console.WriteLine(" _/ _/");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("(0__0)");
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(10, 2);
                Console.WriteLine(" _/ _/");
                Console.SetCursorPosition(10, 3);
                Console.WriteLine("(0__-)");
                System.Threading.Thread.Sleep(200);
            }
        }
    }
}
