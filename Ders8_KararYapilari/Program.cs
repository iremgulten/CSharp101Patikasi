using System;

namespace Ders8_KararYapilari
{
    class Program
    {
        static void Main(string[] args)
        {
/*  *** If Else & Ternary If
            //If Else 
            int time = DateTime.Now.Hour;
            
            if(time>=6 && time<11){
                Console.WriteLine("Gunaydin");
            }else if(time<=18){
                Console.WriteLine("Iyi Gunler");
            }else{
                Console.WriteLine("Iyi Geceler");
            }

            //Ternary If
            string sonuc = time<=18 ? "Iyi Gunler":"Iyi Geceler";

            sonuc = time>=6 && time<11 ? "Gunaydin" : time<=18 ? "Iyi Gunler" : "Iyi Geceler";

            Console.WriteLine(sonuc);
*/
/*  *** Switch Case 
            int month = DateTime.Now.Month;

            //Expression -> Neyi kontrol etmek istiyorum
            switch (month)
            {
                case 1:
                    Console.WriteLine("Ocak Ayindasiniz");
                    break;
                case 2:
                    Console.WriteLine("Subat Ayindasiniz");
                    break;
                case 5:
                    Console.WriteLine("Mayis Ayindasiniz");
                    break;

                default: //Hicbir case uymadi
                    Console.WriteLine("Yanlis veri girisi");
                    break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("Subat Ayindasiniz");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Ilkbahar Ayindasiniz");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("Yaz Ayindasiniz");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("Sonbahar Ayindasiniz");
                    break;
                default: //Hicbir case uymadi
                    Console.WriteLine("Yanlis veri girisi");
                    break;
            }
*/
        }
    }
}
