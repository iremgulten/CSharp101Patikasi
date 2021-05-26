using System;

namespace Ders6_TipDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion (Bilincsiz Donusum)
            //Bir degiskenin kendinden daha yuksek kapasiteli bir degiskene atanmasi
            //Veri kaybi yok

            byte a =5;
            sbyte b = 30;
            short c = 10;

            int d = a+b+c;
            Console.WriteLine("d: " + d);   //output -> d: 45

            long h = d;
            Console.WriteLine("h: " + h);   //output -> h: 45

            float i = h;
            Console.WriteLine("i: " + i);   //output -> i: 45

            string e ="irem";
            char f = 'g';
            object g = e+f+d;
            Console.WriteLine("g: " +g);    //output -> g: iremg45

            //Explicit Conversion (Bilincli Donusum)
            //Donusumleri developer yapmali

            int x = 4;
            byte y = (byte)x;
            Console.WriteLine("y: " +y);    //output -> y: 4

            int z = 100;
            byte t = (byte)z;
            Console.WriteLine("t: " +t);    //output -> t: 100

            float w = 10.3f;
            byte v = (byte)w;
            Console.WriteLine("v: " +v);    //output -> v: 10

            //*** ToString Metodu ***
            int xx = 6;
            string yy = xx.ToString();
            Console.WriteLine("yy: " +yy);  //output -> yy: 6

            string zz = 12.5f.ToString();
            Console.WriteLine("zz: " +zz);  //output -> zz: 12.5

            //*** System.Convert Sinifi ***
            string s1 = "10", s2 = "20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1+sayi2;
            Console.WriteLine("Toplam: " +Toplam);  //output -> Toplam: 30

            //*** Parse Methodu*** -> String ifadeler icin kullanilir
            ParseMethod();

        }

        public static void ParseMethod(){
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);
            Console.WriteLine("rakam1: " +rakam1);  //output -> rakam1: 10
            Console.WriteLine("double1: " +double1);  //output -> double1: 10.25
        }

    }
}
