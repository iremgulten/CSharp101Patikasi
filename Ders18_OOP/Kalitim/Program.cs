using System;
using Bitkiler;
using Hayvanlar;

namespace Kalitim
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inheritance -> Bir ust sinifin bir alt sinifa miras vermesi, alt sinifin ust siniftan miras almasi

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*****************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();

            

 
        }
    }

}
