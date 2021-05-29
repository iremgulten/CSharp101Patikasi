using System;

namespace Recursive_ExtensionMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Recursive -> Ozyinelemeli, kendi kendini cagirabilen metot

            //3^4
            int result = 1;
            for (int i = 0; i < 5; i++)
                result = result * 3;
            Console.WriteLine(result);

            Islemler instance = new();
            Console.WriteLine(instance.Expo(3, 4));

            //Extension Metotlar -> static class icinde static metot yazilmali
            string ifade = "Irem Gulten";
            bool sonuc = ifade.CheckSpaces();
            
            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());   // output -> Irem*Gulten

            Console.WriteLine(ifade.MakeUpperCase());// output -> IREM GULTEN
            Console.WriteLine(ifade.MakeLowerCase());// output -> irem gulten

            int[] dizi = {9,3,6,2,1,5,0};
            dizi.SortArray();
            dizi.EkranaYazdir();    //0 1 2 3 5 6 9

            int sayi = 5;
            Console.WriteLine(sayi.IsEvenNumber()); // false

            Console.WriteLine(ifade.GetFirstCharacter()); // output -> I

        }
    }
    public class Islemler
    {
        public int Expo(int sayi, int us)   // Us alma recursive metot
        {
            if (us < 2)
                return sayi;
            return Expo(sayi, us - 1) * sayi;
        }

        //Expo(3,4)
        //Expo(3,3)*3
        //Expo(3,2)*3*3
        //Expo(3,1)*3*3*3
        //3*3*3*3 = 3^4

    }
    public static class Extension
    {
        public static bool CheckSpaces(this string param)   //Verilen string ifadede space olup olmadigi kontrol eden extension metot
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){  //Verilen string ifadenin spacelerini * yapan extension metot
            string[] dizi = param.Split(" ");
            return string.Join("*",dizi);
        } 

        public static string MakeUpperCase(this string param){  //Verilen string ifadenin harflerini buyuk yapan extension metot
            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param){  //Verilen string ifadenin harflerini kucuk yapan extension metot
            return param.ToLower();
        }
        public static int[] SortArray(this int[] param){    //Int diziyi siralayan extension metot
            Array.Sort(param);
            return param;
        }
        public static void EkranaYazdir(this int[] param){  //Int diziyi ekrana yazdiran extension metot
            foreach (int item in param)
            {
                Console.WriteLine(item);
            }
        }

        public static bool IsEvenNumber(this int param) //Verilen sayinin cift olup olmadigini kontrol eden extension metot
        {
            return param%2==0;
        }

        public static string GetFirstCharacter(this string param) //String ifadenin ilk karakterini donduren extension metot
        {
            return param.Substring(0,1); //0. indisten basla 1 karakter getir
        }
    }
}
