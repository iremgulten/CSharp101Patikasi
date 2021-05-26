using System;

namespace Ders4_Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {

            //Degisken tanimlama yapisi : (Değişken Türü) (Değişken Adı) = (Değeri)

            /*
                Değişken tanımlarken dikkat edilmesi gerekenler:

                -Değişkenler case sensitive yani büyük küçük harf duyarlıdır.
                -Degişken isimleri rakamlarla başlayamaz.
                -Değişken isimleri boşluk içeremez. Yalnızca "_" ifadesi kullanılabilir.
                -Değişken isimlerinin arasında matematiksel ifadeler yani işlem operatörleri kullanılamaz.
                -Class namespace gibi özel isimler kullanılamaz.
                -Değişkenlerin her zaman bir değeri olmak zorundadır. Yoksa null tanımlanmalıdır. Ataması yapılmayan değişkenler kullanıldığında derleyici hata verir.
            */

            int deger = 2;
            string degisken = null;
            string Degisken = null;
        
            byte b =5;          //1 byte 
            sbyte c= 5;         //1 byte 
            
            short s = 5;        //2 byte
            ushort us = 5;      //2 byte

            Int16 i16 = 2;      //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte
            uint ui = 2;        //4 byte

            long l = 4;         //8 byte
            ulong ul = 4;       //8 byte

            //Reel Sayilar
            float f = 5;        //4 byte
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            char ch = '2';       //2 byte
            string str = "Irem"; //sinirsiz

            bool b1 = true;
            bool b2 = false;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);  // Output = 26.05.2021 11:57:50

            object o1 = "x";     //Tum turleri alabilir
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            //String ifadeler 
            string str1 = string.Empty;
            str1 = "irem";
            string ad = "Irem";
            string soyad = "Gulten";
            string tamIsim = ad+" "+soyad;

            //Integer tanimlama sekilleri 
            int integer1 = 5;
            int integer2 = 3;
            int integer3 = integer1*integer2;

            //Boolean
            bool bool1 = 10<2;

            //Degisken donusumu
            string str20 = "20";
            int int20 = 20;
            string yeniDeger = str20 + int20.ToString();
            Console.WriteLine(yeniDeger); // Output = 2020

            int int21 = int20 + Convert.ToInt32(str20); 
            Console.WriteLine(int21); //Output = 40

            int int22 = int20 + int.Parse(str20); //Output = 40


            //DateTime
            string datetime = DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime);    //Output = 26.05.2021

            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);   //Output = 26/05/2021

            //Hour
            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);        //Output = 12:57




        }
    }
}
