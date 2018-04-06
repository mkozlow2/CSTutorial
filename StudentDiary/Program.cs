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
            DiaryStatistics stats;
            while(state == true)
            {
                
                Console.Write("Podaj ocenę: ");
                state = float.TryParse(Console.ReadLine(), out temp);
                if (temp < 1 || temp > 6)
                    continue;
                diary.AddRating(temp);
                stats = diary.ComputeStatistics();
                Console.WriteLine("Srednia ocen: " + stats.AverageGrade);
                Console.WriteLine("Najmniejsza ocena: " + stats.MinGrade);
                Console.WriteLine("Najwyzsza ocena: " + stats.MaxGrade);
                Console.WriteLine("Ilosc ocen w dzienniczku: " + i++);
                Console.ReadKey();
                Console.Clear();
                
            }
        }
    }
}
