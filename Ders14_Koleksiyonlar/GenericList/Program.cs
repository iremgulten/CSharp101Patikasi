using System;
using System.Collections.Generic;

namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection.Generic
            //T -> object turunde, listenin elemanlari hangi tipte oldugunu belirtir
            List<int> sayiListesi = new List<int>();

            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();

            renkListesi.Add("Kirmizi");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sari");
            renkListesi.Add("Yesil");

            //Count -> Eleman sayisi
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            //Foreach ve List.ForEach ile erisim
            foreach (var sayi in sayiListesi)
                Console.WriteLine(sayi);    

            foreach (var renk in renkListesi)
                Console.WriteLine(renk);   

            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));
            

            //Listeden eleman cikarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yesil");
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(2);
            sayiListesi.ForEach(sayi => Console.WriteLine(sayi));
            renkListesi.ForEach(renk => Console.WriteLine(renk));

            //Liste icerisinde arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 liste icinde bulundu");

            //Eleman ile indexe erisim
            Console.WriteLine(renkListesi.BinarySearch("Sari"));

            //Diziyi List'e cevirme
            string[] hayvanlar = {"Kedi","Kopek","Kus"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Listeyi temizleme
            hayvanListesi.Clear();

            //List icinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "Ayse";
            kullanici1.Soyisim = "Yilmaz";
            kullanici1.Yas = 26;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "Ozcan";
            kullanici2.Soyisim = "Caliskan";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();

            yeniListe.Add(new Kullanicilar(){
                Isim = "Deniz",
                Soyisim = "Arda",
                Yas = 24
            });

            foreach (var kullanici in kullaniciListesi)
            {
                Console.WriteLine("Kullanici Adi:"+kullanici.Isim);
                Console.WriteLine("Kullanici Soyadi:"+kullanici.Soyisim);
                Console.WriteLine("Kullanici Yas:"+kullanici.Yas);
            }
            yeniListe.Clear();




            
        }
    }
    public class Kullanicilar{
        private string isim;
        private string soyisim;
        private int yas;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
