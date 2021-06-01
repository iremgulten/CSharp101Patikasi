using System;

namespace StructYapisi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Struct -> Class kullanmayi gerektirecek kadar komplex olmayan yapilar icin veri kapsullemeyi struct yapar
            Struct ya da classtan kalitilamazken inheritancedan kalitilabilir
            */
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.KisaKenar =3;
            dikdortgen.UzunKenar =4;

            Console.WriteLine("Class alan hesabi: {0}",dikdortgen.AlanHesapla());

            DikdortgenStruct dikdortgenStruct = new DikdortgenStruct(3,4);
            //Struct olustururken new kullanmadan da direkt olusturup fieldlarina erisebilirim

            Console.WriteLine("Struct alan hesabi: {0}",dikdortgenStruct.AlanHesapla());

        }
    }

    class Dikdortgen{
        public int KisaKenar;
        public int UzunKenar;
        public Dikdortgen(){
            KisaKenar = 3;
            UzunKenar = 4;
        }
        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }
    }
    struct DikdortgenStruct{
        public int KisaKenar;
        public int UzunKenar;
        public DikdortgenStruct(int kisaKenar, int uzunKenar)
        { //Parametresi olmayan constructor tanimlanamaz
            KisaKenar = kisaKenar;
            UzunKenar = uzunKenar;
        }
        public long AlanHesapla(){
            return this.KisaKenar * this.UzunKenar;
        }
    }
}
