using System;

namespace AbstractSiniflar
{

    public class Civic : Otomobil
    {

        public override Marka HangiMarkaninAraci()
        {
           return Marka.Honda;
        }
        public override Renk StandartRengiNe()
        {
           return Renk.Gri;
        }

    }
}
