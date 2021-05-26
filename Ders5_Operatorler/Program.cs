using System;

namespace Ders5_Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Atama ve islemli atama
            int x = 3;
            int y =3;

            y = y+2;
            Console.WriteLine(y);   //output -> 5
            y += 2;
            Console.WriteLine(y);   //output -> 7
            y /= 1;
            Console.WriteLine(y);   //output -> 7
            x *= 2;
            Console.WriteLine(x);   //output -> 6

            //Mantiksal Operatorler
            // || -> veya %% -> ve ! -> degil

            bool isSucces = true;
            bool isCompleted = false;

            if(isSucces && isCompleted)
                Console.WriteLine("Perfect!");
            
            if(isSucces || isCompleted)
                Console.WriteLine("Great!");

            if(isSucces && !isCompleted)
                Console.WriteLine("Fine!");


            //Iliskisel Operatorler
            // < (kucuk), > (buyuk), <= (kucuk esit), >= (buyuk esit), == (denk), != (denk degil)

            int a = 3;
            int b = 4;

            bool sonuc = a<b;
            Console.WriteLine(sonuc);   //output -> true

            sonuc = a>b;
            Console.WriteLine(sonuc);   //output -> false

            sonuc = a>=b;
            Console.WriteLine(sonuc);   //output -> false

            sonuc = a<=b;
            Console.WriteLine(sonuc);   //output -> true

            sonuc = a==b;
            Console.WriteLine(sonuc);   //output -> false

            sonuc = a!=b;
            Console.WriteLine(sonuc);   //output -> true


            //Aritmetik Operatorler
            // /, *, +, - , % (mod almak)

            int sayi1 = 10;
            int sayi2 = 5;
            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc);   //output -> 2

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc);   //output -> 50

            sonuc1 = sayi1+sayi2;
            Console.WriteLine(sonuc);   //output -> 15

            sonuc1 = sayi1-sayi2;
            Console.WriteLine(sonuc);   //output -> 5

            sonuc1 = sayi1++;
            Console.WriteLine(sonuc);   //output -> 10

            sonuc1 = 20%3;
            Console.WriteLine(sonuc);   //output -> 2


        }
    }
}
