using System;

namespace Ders10_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi tanimlama
            string[] renkler = new string[5];

            string[] hayvanlar = {"Kedi","Kopek","Kus","Maymun"};

            int[] dizi;
            dizi = new int[5];

            //Dizilere deger atama ve erisim
            renkler[0]="Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[3]); //Kus
            Console.WriteLine(renkler[0]);   //Mavi
            Console.WriteLine(dizi[3]);      //10

            //Donguler kullanarak dizi kullanimi
            //Klavyeden girilen n tane sayinin ortalamasini alan program

            Console.Write("Dizinin eleman sayisini giriniz: "); 
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayiDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lutfen {0}.sayiyi giriniz",i+1);
                sayiDizisi[i] = int.Parse(Console.ReadLine());
            }

            int toplam=0;
            foreach (var sayi in sayiDizisi)
                toplam+=sayi;

            Console.WriteLine("Ortalama :"+toplam/diziUzunlugu);



        }
    }
}
