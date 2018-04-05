using System;

namespace CSTest
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in args)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine("Dzień dobry");

        }
    }
}
