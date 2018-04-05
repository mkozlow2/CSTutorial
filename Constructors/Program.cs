using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Dzony");
            Person person3 = new Person(2, "Endrju", "Golota");
            Person person4 = new Person(3, "Seba", "Sebowski", "Radom", 23, "mezczyzna");

        }
    }
}
