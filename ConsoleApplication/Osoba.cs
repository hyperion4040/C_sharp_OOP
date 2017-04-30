using System;
using System.Collections.Generic;
using Firma.Finanse;

namespace ConsoleApplication
{
    public abstract class Osoba : IIstota
    {
        protected Guid nr;
        protected string imie { set; get; }
        protected string nazwisko { set; get; }
        protected DateTime dataUrodzenia;
        public List<Operacja> operacja;

        public Osoba( string imie, string nazwisko)
        {
            this.nr = Guid.NewGuid();
            this.imie = imie;
            this.nazwisko = nazwisko;
        }

        public Osoba()
        {
        }



        public Operacja this[int index]
        {
            get
            {
                //x => { return operacja[index]; } Sprawdzić potem


                 return operacja[index];
            }
            set
            {

                operacja[index] = value;
            }
        }

        public string Gatunek {
            get { return "homosapiens"; }
            set
            {
                throw new Exception("Nie kombinuj");
            } }

        public virtual  string dane()
        {
            return string.Format("{0}: {1} {2} ",nr.ToString(),
                imie,nazwisko
                );
        }


        //Pola
        //Konstruktory
        //Destruktory
        //Indeksatory
        //właściwości
        //metody akcesorów
        //metody
    }
}