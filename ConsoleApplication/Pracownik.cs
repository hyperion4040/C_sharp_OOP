using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using ConsoleApplication;
using Firma.Finanse;
using Firma.Pracownicy.Finanse;

namespace Firma.Pracownicy //Pracownicy.ConsoleApplication
{
    public class Pracownik : Osoba, IEquatable<Pracownik>, IComparable<Pracownik>
    {
        #region POLA STATYCZNE

        static float dodatekWakacyjny = 1000;


        #endregion POLA STATYCZNE

        #region Pola obiektowe

       // private long nrPracownika;

        private UmowaTyp typUmowa;

        private DateTime dataZatrudnienia;

        public Wynagrodzenie wynagrodzenie;

        public SortedDictionary<string, dynamic> zadania;

        #endregion

        #region Konstruktory

        public Pracownik(string imie, string nazwisko)
        {

            this.imie = imie;
            var niedozwoloneZnaki = "%&*^!".ToCharArray();

            foreach (var znak in niedozwoloneZnaki)
            {
                if (nazwisko.Contains(znak))
                {
                    throw new Exception("Nazwisko posiada niedozwolne znaki");
                }
                this.nazwisko = nazwisko;

            }
        }

        public Pracownik( string imie, string nazwisko,DateTime dataZatrudnienia) : this(imie,nazwisko)
        {

            this.dataZatrudnienia = dataZatrudnienia;
         }


        public Pracownik( string imie, string nazwisko,DateTime dataZatrudnienia , Wynagrodzenie wynagrodzenie)
        :this(imie,nazwisko,dataZatrudnienia)
        {

            this.wynagrodzenie = wynagrodzenie;
        }

        public Pracownik(string imie, string nazwisko, DateTime dataZatrudnienia, float zasadnicze,float premia)
        :this(imie,nazwisko,dataZatrudnienia)
        {

            this.wynagrodzenie.Zasadnicze = zasadnicze;
            this.wynagrodzenie.Premia = premia;
        }





        #endregion

        #region Destruktor

        public  bool Equals(Pracownik other)
        {
            var wynagrodzenieP1 = this.wynagrodzenie.Zasadnicze + this.wynagrodzenie.Premia;
            var wynagrodzenieP2 = other.wynagrodzenie.Zasadnicze + other.wynagrodzenie.Premia;
            return wynagrodzenieP1 == wynagrodzenieP2;
        }

        public int CompareTo(Pracownik other)
        {

            var wynagrodzenieP1 = this.wynagrodzenie.Zasadnicze + this.wynagrodzenie.Premia;
            var wynagrodzenieP2 = other.wynagrodzenie.Zasadnicze + other.wynagrodzenie.Premia;
            if (wynagrodzenieP1 > wynagrodzenieP2)
            {
                return 1;
            }
            else
            {
                if (wynagrodzenieP1 == wynagrodzenieP2)
                {
                    return 0;
                }
                else
                {
                    return -1;
                }
            }

        }

        ~Pracownik()
        {
            Console.WriteLine("Usunięto obiekt " + this.GetHashCode());
            //Console.ReadLine(); W visual studio sprawi, że okno nie zamknie się od razu po uruchomieniu programu
        }



        #endregion




        public Pracownik() :base()
        {
            dataZatrudnienia = new DateTime(2012, 3, 11);
//            typUmowa = UmowaTyp.kontrakt;
            typUmowa = UmowaTyp.oPrace;
        }

        public DateTime pobierzDataZatrudnienia() //GET
        {
            return this.dataZatrudnienia;
        }

        public string pobierzDataZatrudnienia(string kod) //GET "en-US"
        {
            var region = new CultureInfo(kod);
            return this.dataZatrudnienia.ToString(region.DateTimeFormat);
        }

        public void ustawDataZatrudnienia(DateTime nowaData) //SET
        {
            if (nowaData.DayOfWeek == DayOfWeek.Saturday || nowaData.DayOfWeek == DayOfWeek.Sunday)
                throw new Exception("Data zatrudnienia nie może być sobotą lub niedzielą");
            else
                this.dataZatrudnienia = nowaData;
        }


//        public DateTime getDataZatrudnienia()
//        {
//            return dataZatrudnienia;
//        }

        public void setUmowaTyp(UmowaTyp typUmowa)
        {
            if (typUmowa == UmowaTyp.oPrace && (DateTime.Now.AddYears(-3) <= this.dataZatrudnienia))
            {
                throw new Exception("Nie mozna tego zrobic");
            }
            else
            {
                this.typUmowa = typUmowa;
            }
        }

        public String getUmowaTyp()
        {
            return typUmowa.ToString();
        }

        #region metody

        public decimal sumaNierozliczonychOperacji()
        {


//            foreach (var operacje in operacja)
//            {
//
//            }

            return operacja.Where(o => o.rozliczneie == false).Sum(o => o.kwota);


        }


        #endregion


        public DateTime DataZatrudnienia
        {
            get { return this.dataZatrudnienia; }
            set { this.ustawDataZatrudnienia(value); }
        }


        public UmowaTyp UmowaTyp
        {
            get { return this.typUmowa; }
            set { this.setUmowaTyp(value); }


        }

        public Guid NumerPracownika
        {
            get { return nr; }
            set { nr = value; }
        }

        public override string dane()
        {
            return base.dane() + ", " + dataZatrudnienia.ToString();
        }

        public static bool operator ==(Pracownik p1, Pracownik p2)
        {
//             var  pensja1 = p1.wynagrodzenie.Zasadnicze + p1.wynagrodzenie.Premia;
//            var pensja2 = p2.wynagrodzenie.Zasadnicze + p2.wynagrodzenie.Premia;
//            return pensja1 == pensja2;
             return p1.Equals(p2);

        }

        public static bool operator !=(Pracownik p1, Pracownik p2)
        {
            return !p1.Equals(p2);
        }


        public override int GetHashCode()
        {
            return wynagrodzenie.GetHashCode();
        }
    }
}