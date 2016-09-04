using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GoGo.Start
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello");
            while (true)
            {
                var key = Console.ReadKey();
                if (key.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                    return;
                }
            }

        }
    }
}
