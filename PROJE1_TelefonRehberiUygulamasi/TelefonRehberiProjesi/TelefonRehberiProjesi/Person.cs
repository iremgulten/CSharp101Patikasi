using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiProjesi
{
    class Person
    {   //Rehberdeki kisilere ait propertylerin yer aldigi sinif
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GsmNumber { get; set; }

        public Person() { }
        public Person(string name, string surname, string gsmNumber)
        {
            this.Name = name;
            this.Surname = surname;
            this.GsmNumber = gsmNumber;
        }
    }
}
