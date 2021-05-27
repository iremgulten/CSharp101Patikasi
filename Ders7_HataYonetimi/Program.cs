using System;

namespace Ders7_HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try //Hata alabilecek kod blogu
            {
                Console.WriteLine("Bir sayi giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmis oldugunuz sayi : " + sayi);
            }
            catch (Exception ex) //Hata yakalaninca ne yapilsin
            {
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }
            finally     // Hata olsa da calissin kod blogu
            {
                Console.WriteLine("Islem tamamlandi");
            }

            try
            {
                int a = int.Parse(null);
            }
            catch (ArgumentNullException ex)    //Spesifik hatalar
            {
                Console.WriteLine("Bos deger girdiniz.");
                Console.WriteLine(ex);
                
            }




        }
    }
}
