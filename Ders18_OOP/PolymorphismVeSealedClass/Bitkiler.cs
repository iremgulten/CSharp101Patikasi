using System;

namespace Bitkiler
{
    public class Bitkiler : Canlilar
    {
        protected void Fotosentez()
        {
            Console.WriteLine("Bitkiler fotosentez yapar.");
        }

        public override void UyaranlaraTepki()
        {//base ile verilmis metodu kapatarak ust siniftan gelen fonksiyonu tamamen ezmis olduk 
            //base.UyaranlaraTepki();
            Console.WriteLine("Bitkiler gunese tepki verir.");
        }
    }
    public class TohumluBitkiler : Bitkiler
    {
        public TohumluBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
            base.UyaranlaraTepki();

        }
        public void TohumlaCogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla cogalir.");
        }
    }
    public class TohumsuzBitkiler : Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.Fotosentez();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void SporlaCogalma()
        {
            Console.WriteLine("Tohumsuz bitkiler sporla cogalir.");
        }
    }
}
