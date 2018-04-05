﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        int id;
        string firstname;
        string lastname;
        string adress;
        int age;
        string gender;
        public Person()
        {
            id = 1;
            firstname = "Mateo";
            lastname = "Wspanialy";
            age = 26;
        }
        public Person(int id, string firstname, string lastname, string adress, int age, string gender)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            this.adress = adress;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            this.firstname = firstname;
            this.lastname = lastname;
            adress = "Warszawa";
            age = 18;
        }
        public Person(int id, string firstname)
        {
            this.id = id;
            this.firstname = firstname;
        }


    }
}
