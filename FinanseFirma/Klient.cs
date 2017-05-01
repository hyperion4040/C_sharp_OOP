using System;

namespace ConsoleApplication
{
    public class Klient : Osoba
    {

        protected KlientTyp typ;

        public KlientTyp Typ
        {
            get { return typ; }
            set { typ = value; }
        }

        public Klient(string imie, string nazwisko, KlientTyp typ) : base(imie, nazwisko)
        {
            this.typ = typ;
        }


        public override string dane()
        {
            return base.dane() + ", " + typ;
        }
    }

    public enum KlientTyp
    {
        firma, indywidualny, instytucjonalny
    }


}