using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enum -> Ardişik indekslerle calismamizi gerektiren durumlarda kullanilir.
            Console.WriteLine(Gunler.Pazar); //Pazar
            Console.WriteLine((int)Gunler.Cumartesi); //6
            //Cuma = 23 dersek
            Console.WriteLine((int)Gunler.Cumartesi); //24

            int sicaklik = 32;
            if (sicaklik <= (int)HavaDurumu.Normal)
            {
                Console.WriteLine("Disariya cikmak icin havanin biraz daha isinmasini bekleyelim.");            
            }else if(sicaklik >= (int)HavaDurumu.Sicak){
                Console.WriteLine("Disariya cikmak icin cok sicak bir gun");
            }else if(sicaklik >= (int)HavaDurumu.Normal && sicaklik<(int)HavaDurumu.CokSicak){
                Console.WriteLine("Hadi disariya cikalim!");
            }

            //Output -> Disariya cikmak icin cok sicak bir gun

        }
    }
    enum Gunler{
        Pazartesi = 1, //0dan degil 1den baslar indeksleme
        Sali,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sicak = 25,
        CokSicak = 30
    }
}
