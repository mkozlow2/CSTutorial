using System;

namespace CSTest
{
    class Program
    {
        static void Main(string[] args)
        {

            ValueTypes();

            for(; ;)
            {
                Greeting();
                Age();
                Settings();
            }

        }

        private static void ValueTypes()
        {
            int maxInt = int.MaxValue;
            int minInt = int.MinValue;
            long maxLong = long.MaxValue;
            long minLong = long.MinValue;

            Console.WriteLine("maxInt = " + maxInt);
            Console.WriteLine("minInt = " + minInt);
            Console.WriteLine("maxLong = " + maxLong);
            Console.WriteLine("minLong = " + minLong);
        }

        /// <summary>
        /// Ustawienia
        /// </summary>
        private static void Settings()
        {
            Console.ReadKey();
            Console.Clear();            // czysci ekran
            Console.ResetColor();       // resetuje kolor czcionki
        }

        /// <summary>
        /// Komunikat zależny od wieku
        /// </summary>
        private static void Age()
        {
            Console.Write("Podaj swoj wiek:\t");
            int age;
            bool result = int.TryParse(Console.ReadLine(), out age);
            //  Console.WriteLine("Twój wiek to: " + age);
            if (age > 18)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Jestes pelnoletni, mozesz dokonac zakupu alkoholu");
            }
            else if (result == false)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Blad wprowadzania wieku!");
            }
            else
                Console.WriteLine("Wracaj do domu smrodzie xD");
        }
       
        /// <summary>
        /// Powitanie użytkownika
        /// </summary>
        private static void Greeting()
        {
            Console.Write("Podaj swoje imie:\t");
            string name = Console.ReadLine();
            Console.WriteLine("Siemano, " + name);
        }
    }
}
