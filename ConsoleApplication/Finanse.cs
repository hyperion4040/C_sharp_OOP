using System;

namespace Firma.Pracownicy.Finanse//ConsoleApplication

{
     public struct Wynagrodzenie
    {
        private float zasadnicze;
        private float premia;
        private float dodStazowy;
        private float nadgodziny;

        public float Zasadnicze
        {
            get { return zasadnicze; }
            set {
                if (value > 0)
                {
                    zasadnicze = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("zasadnicze nie może być mniejsze niż 0");
                }
            }



        }



        public float Premia
        {
            get { return premia; }
            set { premia = value; }
        }

        public float DodStazowy
        {
            get { return dodStazowy; }
            set { dodStazowy = value; }
        }

        public float Nadgodziny
        {
            get { return nadgodziny; }
            set { nadgodziny = value; }
        }
    }
}