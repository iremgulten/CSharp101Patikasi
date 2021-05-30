using System;
using System.Collections.Generic;
using System.Collections;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            Console.WriteLine("**20 Adet Pozitif Sayi Girisi Yapiniz**");
            ArrayList numberList = getArray();  //Kullanicidan pozitif sayilar alindi..
            SortArray(numberList);  //Array siralandi

            ArrayList max3 = new ArrayList();
            ArrayList min3 = new ArrayList();

            Console.WriteLine("***Maximum 3 eleman Arrayi***");
            for (int i = numberList.Count - 3; i < numberList.Count; i++)   //Son 3 deger max olarak atandi
                max3.Add(numberList[i]);

            foreach (int number in max3)
                Console.WriteLine(number);

            Console.WriteLine("\n\n***Minimum 3 eleman Arrayi***");     //Ilk 3 deger min olarak atandi
            for (int i = 0; i < 3; i++)
                min3.Add(numberList[i]);

            foreach (int number in min3)
                Console.WriteLine(number);

            
            float max3Mean = ArrayMean(max3);   //Max degerlerin ortalamasi
            Console.WriteLine("\n\n***Maximum 3 eleman Array Ortalamasi : "+max3Mean);

            float min3Mean = ArrayMean(min3);   //Min degerlerin ortalamasi
            Console.WriteLine("\n\n***Minimum 3 eleman Array Ortalamasi : "+min3Mean);

            float sumMean = max3Mean + min3Mean;    //Max ve Min Degerlerin ortalama toplami
            Console.WriteLine("\n\n***Ortalama toplamlari : "+sumMean);


        }
        public static ArrayList getArray()  //Kullanicidan 20 adet pozitif sayi alan fonksiyon
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

        public static void SortArray(ArrayList array)   //Parametre olarak aldigi Arrayi siralayan fonksiyon
        {
            array.Sort();
        }

        public static float ArrayMean(ArrayList array)  //Parametre olarak aldigi Arrayin ortalamasini bulan fonksiyon
        {
            int sum = 0;
            foreach (int number in array)
                sum += number;

            return sum / array.Count;
        }
    }
}
