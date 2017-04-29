using System;
using System.Collections.Generic;
using ConsoleApplication;
using Firma.Pracownicy;
using Firma.Finanse;
using Firma.Pracownicy.Finanse;

namespace WSB
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            #region utworzenieObiektu do .NET 2.0
//            var pracownik = new Pracownik();
////            Console.WriteLine("Pracownik ma taki typ umowy: " + pracownik.getUmowaTyp());
//            pracownik.ustawDataZatrudnienia(DateTime.Now.AddDays(1));
//            pracownik.setUmowaTyp(UmowaTyp.oZlecenie);
//            pracownik.imie = "Adrian";
//            pracownik.nazwisko = "Kozłowski";
//            pracownik.wynagrodzenie.zasadnicze = 20000000;
//            pracownik.wynagrodzenie.premia = 1000000;
//            pracownik.operacja = new List<Operacja>();
//            var o1 = new Operacja();
//            o1.tytul = "Zaliczka na nowe korki";
//            o1.kwota = 5000;


            #endregion
//

            #region utworzenie obiektu od .NET 3.0

//            var pracownik2 = new Pracownik()
//            {
//                imie = "Arkadiusz",
//                nazwisko = "Milik",
//                DataZatrudnienia = DateTime.Now,
//                UmowaTyp = UmowaTyp.kontrakt,
//
//                wynagrodzenie = new Wynagrodzenie()
//                {
//                    Zasadnicze = 44444444444,
//                    Premia =  500000
//                },
//
//
//
//                operacja = new List<Operacja>()
//                {
//                    new Operacja() {kwota = 4000, tytul = "laptop", rozliczneie = true},
//                    new Operacja() {kwota = 2000, tytul = "telefon", rozliczneie = false},
//                    new Operacja(){kwota = 4000,tytul = "laptop",rozliczneie = false}
//
//                }
//
//
//            };
//
//
//
//
//            Console.WriteLine(pracownik2.sumaNierozliczonychOperacji());
//            Console.WriteLine(pracownik2.DataZatrudnienia);

            #endregion

            Pracownik p2 = new Pracownik("Adrian", "Kozłowski", new DateTime(2011,1,1))
            {
               // DataZatrudnienia = new DateTime(2010,1,1),
                wynagrodzenie = new Wynagrodzenie()
                {
                    Zasadnicze = 3000,
                    Premia = 2000

                }
            };

//            Console.WriteLine(p2.imie + " " + p2.nazwisko);
//            Console.WriteLine(p2.dane());
//            Console.WriteLine(p2.ToString());
            daneOsoba(p2);


        }

        static void daneOsoba(Osoba osoba)
        {
            if ( osoba is Pracownik)
            {
                Console.WriteLine(((Pracownik) osoba).UmowaTyp );
            }
            Console.WriteLine(osoba.dane());
        }


    }
}