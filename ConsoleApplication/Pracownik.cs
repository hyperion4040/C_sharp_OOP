using System;
using System.Collections.Generic;
using ConsoleApplication;

namespace EmptyProject
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
        private String imie;
        private String nazwisko;
        private List<Operacja> operacja;
        #endregion




        public Pracownik()
        {
            dataZatrudnienia = new DateTime(2014,3,11);
            typUmowa = UmowaTyp.kontrakt;
        }



        public DateTime getDataZatrudnienia()
        {
            return dataZatrudnienia;
        }

        public void setUmowaTyp(UmowaTyp typUmowa)
        {
            if (dataZatrudnienia.AddYears(3) >= DateTime.Now)
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





    }
}