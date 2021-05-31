using System;

namespace EncapsulationProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            //Encapsulation -> Bir ozelligi baska siniflardan saklamak 
            //Property kullanilarak (get,set) ozellik disariya kontrollu acilir
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim = "Ayse";
            ogrenci.Soyisim = "Yilmaz";
            ogrenci.OgrenciNo = 293;
            ogrenci.Sinif = 3;

            ogrenci.OgrenciBilgileriniGetir();

            ogrenci.SinifAtlat();

            ogrenci.OgrenciBilgileriniGetir();
      
        }
    }
    class Ogrenci{
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { 
            get { return isim; }
            set { isim = value; }
        }

        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set {
                if(value<=1){
                    Console.WriteLine("Sinif en az 1 olabilir");
                    sinif = 1;
                }else {
                    sinif = value;
                }
            }}

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Sinif = sinif;
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }
        public Ogrenci(){   
        }
        public void OgrenciBilgileriniGetir(){
            Console.WriteLine("***** Ogrenci Bilgileri *****");
            Console.WriteLine("Ogrenci Adi : {0}",this.Isim);
            Console.WriteLine("Ogrenci Soyadi : {0}",this.Soyisim);
            Console.WriteLine("Ogrenci Adi : {0}",this.OgrenciNo);
            Console.WriteLine("Ogrenci Adi : {0}",this.Sinif);
        }

        public void SinifAtlat(){
            this.Sinif = this.Sinif+1;
        }
        public void SinifDusur(){
            this.Sinif = this.Sinif-1;
        }
    }
}
