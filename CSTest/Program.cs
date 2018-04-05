using System;

namespace CSTest
{
    class Program
    {
        static void Main(string[] args)
        {
                foreach (var item in args)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("\nDzień dobry");
           // string name = args[0];
           // Console.WriteLine(name);
        }
        
    }
}
