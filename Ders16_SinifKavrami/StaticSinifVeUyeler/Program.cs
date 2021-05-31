using System;

namespace StaticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bir sinifin static olamayan elemanlarina nesnelerle erişirken static olan metotlara ve ozelliklere nesne oluşturmadan o sınıfın ismi aracılığıyla erişiriz.
            Console.WriteLine("Calisan Sayisi : {0}",Calisan.CalisanSayisi);

            Calisan calisan = new Calisan("Ayse","Yilmaz","IK");

            Console.WriteLine("Calisan Sayisi : {0}",Calisan.CalisanSayisi);

            Console.WriteLine("Toplama islemi sonucu : {0}",Islemler.Topla(100,200));
            Console.WriteLine("Cikarma islemi sonucu : {0}",Islemler.Cikar(200,100));

        }
    }
    class Calisan{
        private static int calisanSayisi;

        public static int CalisanSayisi { get => calisanSayisi;}

        private string isim;
        private string soyisim;
        private string Departman;

        static Calisan(){
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi ++;
        }
    }
    static class Islemler{
        public static long Topla(int sayi1,int sayi2){
            return sayi1+sayi2;
        }
        public static long Cikar(int sayi1,int sayi2){
            return sayi1-sayi2;
        }
    }
}
