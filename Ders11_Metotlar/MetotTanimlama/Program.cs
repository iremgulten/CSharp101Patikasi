using System;

namespace MetotTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {
            //Metotlar programi parcalara ayirmak icin kullanilir
            //Erisim belirteci geri_donustipi metot_Adi(parametreListesi)
            //{
                //komutlar;
                //return;
            //}

            int a=2;
            int b=3;
            Console.WriteLine(a+b); // output -> 5

            
            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc); // output -> 5



            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString()); // output -> 5

            int sonuc2 = ornek.ArttirVeTopla(ref a,ref b);  //ref ile a ile b'nin bellekteki adreslerinde degisiklik yapiliyor
            ornek.EkranaYazdir(sonuc2.ToString());  // output -> 7
            ornek.EkranaYazdir((a+b).ToString());   // output -> 7
        }

        static int Topla(int deger1,int deger2){//Call by value
            return (deger1+deger2);
        }
         
    }
    class Metotlar{
        public void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(ref int deger1,ref int deger2){ // Call by Ref
            deger1+=1;  //ref ile geldigi icin global degisken degismis oldu
            deger2+=1;
            return deger1+deger2;
        }
    }
}
