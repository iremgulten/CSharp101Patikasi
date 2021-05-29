using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();   
            // liste.Add("Ayse");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('a');
            
            //Verilere Erisim
            //Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            //    Console.WriteLine(item);

            //AddRange -> collection tipinde veri ekleme
            Console.WriteLine("*** Add Range ***");
            //string[] renkler = {"Kirmizi","Sari","Yesil"};
            List<int> sayilar = new List<int>(){1,8,3,7,9,92,5};

            //liste.AddRange(renkler);
            liste.AddRange(sayilar);

            foreach (var item in liste)
               Console.WriteLine(item);

            //Sort -> Siralama
            Console.WriteLine("*** Sort ***");
            liste.Sort();
            foreach (var item in liste)
               Console.WriteLine(item);

            //BinarySearch
            Console.WriteLine("*** Binary Search ***")
            ;
            Console.WriteLine(liste.BinarySearch(9));

            //Reverse
            Console.WriteLine("*** Reverse ***");
            liste.Reverse();
            foreach (var item in liste)
               Console.WriteLine(item);

            //Clear
            Console.WriteLine("*** Clear ***");
            liste.Clear();
            foreach (var item in liste)
               Console.WriteLine(item);
            




        }
    }
}
