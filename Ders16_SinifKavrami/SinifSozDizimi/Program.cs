using System;

namespace SinifSozDizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*class SinifAdi{
                [Erisim Belirleyici] [Veri Tipi] OzellikAdi;
                [Erisim Belirleyici] [Geri Donus Tipi] MEtotAdi([Parametre Listesi]){
                    Metot Komutları
                }
            }
            */

            /*Erisim Belirleyiciler
            Public -> Her yerden erisilebilir
            Private -> Tanimlandigi sinifa ozel
            Internal -> Proje icerisinde
            Protected -> Sadece tanimlandigi sinif ya da miras alan sinif
            */

            Calisan calisan1 = new Calisan("Ayse","Kara", 23425634, "İnsan Kaynaklari");
            //calisan1.Ad = "Ayse";
            //calisan1.Soyad = "Kara";
            //calisan1.No = 23425634;
            //calisan1.Ad = "İnsan Kaynaklari";
            calisan1.CalisanBilgileri();

            Console.WriteLine("****************");
            Calisan calisan2 = new Calisan("Deniz", "Arda", 24625634, "Satin Alma");
            //calisan2.Ad = "Deniz";
            //calisan2.Soyad = "Arda";
            //calisan2.No = 24625634;
            //calisan2.Ad = "Satin Alma";
            calisan2.CalisanBilgileri();

            Calisan calisan3 = new Calisan("Aydin", "Sancak");
            calisan3.CalisanBilgileri();
            //Yazdirma esnasinda gonderilmeyen degerler icin tiplerin default degerleri verilir



        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman){
            //Constructor(Kurucu) metot
            //Nesne olusturulunca otomatik olarak calistirilmasi gerekenler burada 
            //this -> sinifin elemani demek
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }
        public Calisan(string ad, string soyad){
            this.Ad = ad;
            this.Soyad = soyad;
        }
        public void CalisanBilgileri(){
            Console.WriteLine("Calisan Adi: {0}",Ad);
            Console.WriteLine("Calisan Soyadi: {0}",Soyad);
            Console.WriteLine("Calisan Numarasi: {0}",No);
            Console.WriteLine("Calisan Departmani: {0}",Departman);
        }
    }
}
