using System;

namespace Ders9_ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {

/* *** For Loop

            //Ekrandan girilen sayiya kadar olan tek sayilari ekrana yazdir.
            Console.WriteLine("Lutfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayac; i++)
            {
                //komutlar
                if (i % 2 == 1)
                    Console.WriteLine(sayac);
            }

            //1-1000 arasindaki tek ve cift sayilarin kendi iclerinde toplami.
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 1)
                    tekToplam += i;
                else
                    ciftToplam += i;
            }

            Console.WriteLine("Tek toplam : " + tekToplam); //output : 250000
            Console.WriteLine("Cift toplam : " + ciftToplam); //output : 250500 


            //break -> looptan cikayim continue  -> dongunun o cycle atlasin

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    break;
                Console.WriteLine(i); //output 1 2 3
            }

            for (int i = 0; i < 10; i++)
            {
                if (i == 4)
                    continue;
                Console.WriteLine(i); //output 1 2 3 5 6 7 8 9
            }
*/
/*  *** While Loop
            //1'den baslayarak consoledan girilen sayiya kadar ortalama hesaplayip yazdiran program 
            Console.Write("Lutfen bir sayi giriniz: ");
            int sayi = int.Parse(Console.ReadLine()); 
            int sayac = 1;
            int toplam =0;
            while (sayac<=sayi)
            {
               toplam+=sayac;
               sayac++;
            }

            Console.WriteLine(toplam/sayi);

            //'a'dan 'z'ye kadar tum harfleri consolea yazdir

            char character = 'a';
            while (character < 'z')
            {
                Console.WriteLine(character);
                character ++;
            }
*/
// Foreach Loop
string[] arabalar = {"BMW","Ford","Toyota","Nissan"};
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }

        }
    }
}
