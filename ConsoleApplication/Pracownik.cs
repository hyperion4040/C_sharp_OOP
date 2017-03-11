using System;

namespace EmptyProject
{
    public class Pracownik
    {
        private DateTime dataZatrudnienia;
        private UmowaTyp typUmowa;


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