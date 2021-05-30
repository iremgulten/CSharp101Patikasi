using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
            //Negatif ve numeric olmayan girişleri engelleyin.
            //Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
            //Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.

            Console.WriteLine("**20 Adet Pozitif Sayi Girisi Yapiniz**");
            ArrayList number_list = getArray();

            ArrayList primeNumbers = new ArrayList();
            ArrayList nonPrimeNumbers = new ArrayList();

            foreach (int number in number_list) //Elemanlarin asal ve asal olmayan olarak ayrilmasi
            {
                int control = 0;
                for (int i = 2; i < number; i++)
                {
                    if (number % i == 0)
                        control++;
                }
                if (control != 0)
                {
                    nonPrimeNumbers.Add(number);
                }
                else
                {
                    primeNumbers.Add(number);
                }
            }
            //Prime&Non Prime Numbers
            Console.WriteLine("\n\n**** Asal Sayilar ****");
            PrintArray(primeNumbers);

            Console.WriteLine("\n\n**** Asal Olmayan Sayilar ****");
            PrintArray(nonPrimeNumbers);

            //Array Sorting
            SortArray(primeNumbers);    
            SortArray(nonPrimeNumbers);

            Console.WriteLine("\n\nBuyukten Kucuge Siralama Sonrasi");

            Console.WriteLine("**** Asal Sayilar ****");
            PrintArray(primeNumbers);
            Console.WriteLine("\n\n**** Asal Olmayan Sayilar ****");
            PrintArray(nonPrimeNumbers);

            //Array Count&Mean
            Console.WriteLine("\n\n***Asal Sayi Arrayi:");
            CountAndMean(primeNumbers);
            Console.WriteLine("\n\n***Asal Olmayan Sayi Arrayi:");
            CountAndMean(nonPrimeNumbers);


        }
        public static ArrayList getArray()
        {
            ArrayList numbers = new ArrayList();
            int number = 0;

            //Kullanicidan 20 adet Pozitif Sayi Al
            for (int i = 0; i < 20; i++)
            {
                string temp = Console.ReadLine();
                bool result = int.TryParse(temp, out number);//Numeric mi kontrol
                if (result)
                {
                    number = Int32.Parse(temp);
                    if (number < 0)
                    {   //Negatif mi kontrol
                        Console.WriteLine("Pozitif sayi girmelisiniz. Tekrar giriniz..");
                        i--;
                        continue;
                    }
                    numbers.Add(number);
                }
                else
                {
                    Console.WriteLine("Pozitif sayi girmelisiniz. Tekrar giriniz..");
                    i--;
                    continue;
                }
            }
            return numbers;
        }
        public static void SortArray(ArrayList array)    //Listler buyukten kucuge siralaniyor
        {
            array.Sort();
            array.Reverse();
        }
        public static void CountAndMean(ArrayList array){
            int arrayCount = array.Count;
            Console.WriteLine("Eleman Sayisi: "+arrayCount); //Eleman sayisi
            int toplam =0 ;
            foreach (int item in array)
            {
                toplam +=item;
            }
            Console.WriteLine("Ortalama: " + toplam/arrayCount);
            
        }
        public static void PrintArray(ArrayList array){
            foreach (int item in array)
            {
                Console.WriteLine(item);
            }
        }
    
    
    }
}
