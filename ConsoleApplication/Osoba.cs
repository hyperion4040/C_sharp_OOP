using System;
using System.Collections.Generic;
using Firma.Finanse;

namespace ConsoleApplication
{
    public class Osoba
    {
        protected Guid nr;
        protected string imie { set; get; }
        protected string nazwisko { set; get; }
        protected DateTime dataUrodzenia;
        protected List<Operacja> operacja;


        public virtual  string dane()
        {
            return string.Format("{0}: {1} {2} ",nr.ToString(),
                imie,nazwisko
                );
        }




    }
}