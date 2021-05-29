using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Veriler key,value olarak tutulur
            //Key'ler uniq olmali ->olmazsa Runtime error
            //system.collection.generic

            Dictionary<int,string> kullanicilar = new Dictionary<int,string>();

            kullanicilar.Add(10,"Ayse Yilmaz");
            kullanicilar.Add(12,"Ahmet Yilmaz");
            kullanicilar.Add(18,"Deniz Arda");
            kullanicilar.Add(20,"Ozcan Cosar");

            //Elemana erisim
            Console.WriteLine("*** Elemanlara Erisim ***");
            Console.WriteLine(kullanicilar[12]); //Key 12 olan eleman

            foreach (var item in kullanicilar)
                Console.WriteLine(item);

            //Count
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine(kullanicilar.ContainsKey(12)); //Key 12 olan eleman var mi
            Console.WriteLine(kullanicilar.ContainsValue("Irem")); //Irem valuesine sahip eleman var mi?

            //Remove -> Key kullanilarak yapilir
            Console.WriteLine("*** Remove ***");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
                Console.WriteLine(item.Value);
            
            //Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in kullanicilar.Keys)
                Console.WriteLine(item);
            
            //Values
            Console.WriteLine("*** Values ***");
            foreach (var item in kullanicilar.Values)
                Console.WriteLine(item);


            


        }
    }
}
