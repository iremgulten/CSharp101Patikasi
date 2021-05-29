using System;

namespace Ders13_HazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hosgeldiniz";
            string degisken2 = "CSharp";

            //Length ->Karakter sayisi
            Console.WriteLine(degisken.Length); //output -> 29


            //ToUpper ->Tum karakterler buyuk & ToLower ->Tum karakterler kucuk
            Console.WriteLine(degisken.ToUpper()); //output -> DERSIMIZ CSHARP, HOSGELDINIZ
            Console.WriteLine(degisken.ToLower()); //output -> dersimiz csharp, hosgeldiniz


            //Concat -> string birlestirme
            Console.WriteLine(degisken,"Merhaba!"); //output -> Dersimiz CSharp, Hosgeldiniz Merhaba!

            //Compare & CompareTo -> Karakter sayilari esit 0, birinci daha buyuk 1, birinci daha kucuk -1 
            //Compare son parametre ignorecase durumu
            Console.WriteLine(degisken.CompareTo(degisken2)); //output -> 1
            Console.WriteLine(String.Compare(degisken,degisken2,true)); //output -> 0
            Console.WriteLine(String.Compare(degisken,degisken2,false));  //output -> 1

            //Contains 
            Console.WriteLine(degisken.Contains(degisken2)); //output -> true
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz")); //output -> true
            Console.WriteLine(degisken.StartsWith("Dersimiz")); //output -> true

            //IndexOf -> Varsa ilk karakterin indexi doner
            Console.WriteLine(degisken.IndexOf("CS")); //output 9
            Console.WriteLine(degisken.IndexOf("I")); //output -1
            Console.WriteLine(degisken.LastIndexOf("i")); // output 26

            //Insert -> verilen indexten baslayip kelimeyi ekler
            Console.WriteLine(degisken.Insert(0,"Merhaba")); // output Merhaba Dersimiz CSharp, Hosgeldiniz

            //PadLeft , PadRight
            Console.WriteLine(degisken2.PadLeft(30)); //karakter sayisi 30 olana kadar sola bosluk
            Console.WriteLine(degisken.PadRight(30,'*')); //karakter sayisi 30 olana kadar saga *

            //Remove 
            Console.WriteLine(degisken.Remove(10)); //output -> Dersimiz C
            Console.WriteLine(degisken.Remove(5,3));//output -> Dersi CSharp, Hosgeldiniz
            Console.WriteLine(degisken.Remove(0,1));//output -> ersimiz CSharp, Hosgeldiniz

            //Replace -> ilk parametre yerine ikincisini yazar
            Console.WriteLine(degisken.Replace("Charp","C#"));
            Console.WriteLine(degisken.Replace(" ","*"));

            //Split -> Verilen parametreye gore keserek diziye atar
            Console.WriteLine(degisken.Split(" ")[1]); //output-> CSharp,

            //Substring
            Console.WriteLine(degisken.Substring(4)); //4. indisten baslayip sona kadar
            Console.WriteLine(degisken.Substring(4,6)); //4.indisten baslayarak 6 karakter gider




            





        }
    }
}
