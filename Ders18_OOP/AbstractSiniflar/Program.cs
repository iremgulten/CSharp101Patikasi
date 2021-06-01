using System;

namespace AbstractSiniflar
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
            Abstraction (soyutlama)
            Interface ve virtual metotlarin birlesimi denebilir
            new() ile turetilemezler
            Abstract metotlarin govdesi yazilmaz
            Abstract classtan tureyen siniflar tum abstract metotlari override etmeli
            */



            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe().ToString());
        }
    }
}
