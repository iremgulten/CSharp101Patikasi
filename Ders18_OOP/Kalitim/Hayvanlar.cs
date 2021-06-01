using System;
namespace Hayvanlar
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir.");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon(); //Base anahtar kelimesiyle kalitilan sinifin protected metoduna erisim
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void SurunerekHareket()
        {
            Console.WriteLine("Surungenler surunerek hareket ederler.");

        }
    }
    public class Kuslar : Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Beslenme();
            base.Solunum();
            base.Bosaltim();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar ucar.");

        }
    }
}
