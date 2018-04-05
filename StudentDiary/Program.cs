using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDiary
{
    class Program
    {
        static void Main(string[] args)
        {
            float temp = 0, i = 1;
            bool state = true;
            Diary diary = new Diary();
            while(state == true)
            {
                
                Console.Write("Podaj ocenę: ");
                state = float.TryParse(Console.ReadLine(), out temp);
                if (temp < 1 || temp > 6)
                    continue;
                diary.AddRating(temp);

                Console.WriteLine("Srednia ocen: " + diary.CalculateAverage());
                Console.WriteLine("Najmniejsza ocena: " + diary.GiveMinRating());
                Console.WriteLine("Najwyzsza ocena: " + diary.GiveMaxRating());
                Console.WriteLine("Ilosc ocen w dzienniczku: " + i++);
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
