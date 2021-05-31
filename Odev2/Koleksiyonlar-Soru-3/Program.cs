using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            Console.WriteLine("Lutfen cumle giriniz: ");
            string sentence = Console.ReadLine();
            
            ArrayList vowelLetters = GetVowels(sentence);   //Girilen cumledeki sesli harfler arraylistte tutuluyor.

            Console.WriteLine("\n\n**Siralama Oncesi Sesli Harfler : ");
            foreach (char letter in vowelLetters)
                Console.WriteLine(letter);

            Console.WriteLine("\n\n**Siralama Sonrasi Sesli Harfler : ");
            foreach (char letter in vowelLetters)
                Console.WriteLine(letter); 

        }
        public static ArrayList GetVowels(String sentence){
            string vowels= "aeıioöuü";
            ArrayList letters = new ArrayList();

            foreach (char letter in sentence)
            {
                //Cumle icindeki her bir harf sesli harflerle karsilastirilip uyan harf arraye atiliyor
                if(vowels.Contains(letter))
                    letters.Add(letter);
            }
            return letters;
        }
        public static void ArraySort(ArrayList array){
            array.Sort();
        }
    }
}
