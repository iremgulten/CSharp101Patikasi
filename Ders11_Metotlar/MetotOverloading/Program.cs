using System;

namespace MetotOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //Out Parametreler -> return ifadesi yerine out parametreler kullanilabilir
            //out parametrelerin ilk degeri olmak zorunda degil 
            string sayi = "999";
            bool sonuc = int.TryParse(sayi,out int outSayi);

            if(sonuc)
                Console.WriteLine("Basarili: "+outSayi);
            else 
                Console.WriteLine("Basarisiz");

            
            Metotlar instance = new Metotlar();
            instance.Topla(4,5,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);

// *** Metot Overloading -> Aynı metoda farklı parametreler alacak sekilde birden fazla metot sekilde yazmak

            // Metot Imzasi -Z metotAd + parametre sayisi + parametre

            int ifade = 999;
            instance.Yazdir(ifade.ToString());
            instance.Yazdir(ifade);
            instance.Yazdir("Irem","Gulten");


        }
    }

    class Metotlar{
        public void Topla(int a,int b,out int toplam){
            toplam = a+b;
        }

        public void Yazdir(string veri){
            Console.WriteLine(veri);
        }
        public void Yazdir(int veri){
            Console.WriteLine(veri);
        }

        public void Yazdir(string veri,string veri2){
            Console.WriteLine(veri+veri2);
        }

    }
}
