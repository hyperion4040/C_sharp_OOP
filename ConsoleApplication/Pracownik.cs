using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using ConsoleApplication;
using Firma.Finanse;
using Firma.Pracownicy.Finanse;

namespace Firma.Pracownicy //Pracownicy.ConsoleApplication
{
    public class Pracownik
    {
        #region POLA STATYCZNE

        static float dodatekWakacyjny = 1000;

        #endregion POLA STATYCZNE

        #region Pola obiektowe

        private long nrPracownika;
        private DateTime dataZatrudnienia;
        private UmowaTyp typUmowa;
        public String imie;
        public String nazwisko;
        public List<Operacja> operacja;
        public Wynagrodzenie wynagrodzenie;

        #endregion




        public Pracownik()
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
    }
}