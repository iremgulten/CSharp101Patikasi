using System;
using Bitkiler;
using Hayvanlar;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polymorphism ->Virtual metotlarla uygulanır. Boylece kalitim alinan sinifta taninli fonksiyon daha sonra alt siniflarda override anahtar kelimesiyle ezilerek yeniden yazilabilir.

            TohumluBitkiler tohumluBitki = new TohumluBitkiler();
            tohumluBitki.TohumlaCogalma();

            Console.WriteLine("*****************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();
        }
    }

}
