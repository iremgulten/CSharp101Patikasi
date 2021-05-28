using System;

namespace Ders10_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
/* Dizi tanimlama - Deger Atama - Erisim
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
*/

// Array Sinifi Metodlari
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("*** Sirasiz Dizi***");
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            // output 23 12 4 86 72 3 11 17
            

            Console.WriteLine("*** Sirali Dizi***"); 
            Array.Sort(sayiDizisi);  //kucukten buyuge siralama
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //output 3 4 11 12 17 23 72 86


            //Clear
            Console.WriteLine("*** Array Clear***");
            Array.Clear(sayiDizisi,2,2);    //2. indisten itibaren 2 eleman siralanir
            //output 3 4 0 0 17 23 72 86


            //Reverse -> Diziyi ters cevirme
            Console.WriteLine("*** Array Reverse***");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //output 86 72 23 17 0 0 4 3

            //IndexOf -> Verilen eleman dizide varsa indis doner
            Console.WriteLine("*** Array IndexOf***");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));  
            //output 2


            //Resize -> Yeniden Boyutlandirma
            Console.WriteLine("*** Array Resize***");
            Array.Resize(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }
            //output 86 72 23 17 0 0 4 3 99








        }
    }
}
