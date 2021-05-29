using System;

namespace DateTime_MathMetotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime Kutuphanesi
            Console.WriteLine(DateTime.Now); //output -> 29.05.2021 22:51:38
            Console.WriteLine(DateTime.Now.Date); //output -> 29.05.2021 00:00:00
            Console.WriteLine(DateTime.Now.Day); //output -> 29
            Console.WriteLine(DateTime.Now.Month); //output -> 5
            Console.WriteLine(DateTime.Now.Year); //output -> 2021
            Console.WriteLine(DateTime.Now.Hour); //output -> 22
            Console.WriteLine(DateTime.Now.Minute); //output -> 51
            Console.WriteLine(DateTime.Now.Second); //output -> 38

            Console.WriteLine(DateTime.Now.DayOfWeek); //output -> Saturday
            Console.WriteLine(DateTime.Now.DayOfYear); //output -> 149

            Console.WriteLine(DateTime.Now.ToLongTimeString()); // output -> 22:59:06
            Console.WriteLine(DateTime.Now.ToShortTimeString()); //output -> 22:59

            Console.WriteLine(DateTime.Now.AddDays(2)); //output -> 31.05.2021 23:02:40
            Console.WriteLine(DateTime.Now.AddHours(3)); //output -> 30.05.2021 02:02:40
            Console.WriteLine(DateTime.Now.AddSeconds(30)); //output -> 29.05.2021 23:03:10
            Console.WriteLine(DateTime.Now.AddMonths(5)); //output -> 29.10.2021 23:02:40
            Console.WriteLine(DateTime.Now.AddYears(10)); //output -> 29.05.2031 23:02:40
            Console.WriteLine(DateTime.Now.AddMilliseconds(50)); //output-> 29.05.2021 23:02:40

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd"))
            ; //output -> 29
            Console.WriteLine(DateTime.Now.ToString("ddd")); //output -> Cum
            Console.WriteLine(DateTime.Now.ToString("dddd")); //output -> Cumartesi
            Console.WriteLine(DateTime.Now.ToString("MM"))
            ; //output -> 05
            Console.WriteLine(DateTime.Now.ToString("MMM")); //output -> May
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //output -> Mayis
            Console.WriteLine(DateTime.Now.ToString("yy")); //output -> 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //output -> 2021


            //Math Kutuphanesi
            Console.WriteLine(Math.Abs(-25)); //Mutlak
            Console.WriteLine(Math.Sin(15)); //Sinus
            Console.WriteLine(Math.Cos(25)); //Cosinus
            Console.WriteLine(Math.Tan(25)); //Tanjant

            Console.WriteLine(Math.Ceiling(22.3)); //Buyuk en kucuk tam sayi ->23
            Console.WriteLine(Math.Round(22.3)); //Hangisine daha yakinsa -> 22
            Console.WriteLine(Math.Round(22.7)); //Kucuk en buyuk sayi -> 22

            Console.WriteLine(Math.Min(2,6)); //Minimum
            Console.WriteLine(Math.Max(22,3)); //Maximum

            Console.WriteLine(Math.Pow(3,4)); //3^4
            Console.WriteLine(Math.Sqrt(9)); //Karekok

            Console.WriteLine(Math.Log(9));//Logaritma e^9

            Console.WriteLine(Math.Exp(3)); //e^3
            Console.WriteLine(Math.Log10(10)); //log10^10
            



            








        }
    }
}
