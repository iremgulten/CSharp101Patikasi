using System;
using System.Collections.Generic;
using System.Text;

namespace TelefonRehberiProjesi
{
    class PhoneBook
    {
        //Telefon Rehberi sinifi. Kisiler Person tipli List'te tutulmaktadir.
        public static List<Person> phoneBook;

        static PhoneBook()
        {
            phoneBook = DefaultPersons();
        }
        public static List<Person> DefaultPersons()
        {
            return new List<Person>()   // Baslangicta defult olarak rehbere eklenen 5 kisi
            {
                new Person("İrem", "Gulten", "1111111111"),
                new Person("Elif", "Gulten", "2222222222"),
                new Person("Merve", "Metinoglu", "3333333333"),
                new Person("Nurdan", "Kaya", "4444444444"),
                new Person("Rana", "Akkus", "5555555555")
            };
        }
    }
}
