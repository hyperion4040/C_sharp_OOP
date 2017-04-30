using System;
using System.Collections.Generic;
using System.Collections.Specialized;
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

                },
                operacja = new List<Operacja>()
                {
                    new Operacja(){tytul = "Szkolenie  języki skryptowe", data = DateTime.Now, kwota = 2000},
                    new Operacja(){tytul = "RWD", data = DateTime.Now, kwota =  3000},
                    new Operacja(){tytul = "Angular JS", data = DateTime.Now, kwota = 3500}
                },


                zadania = new SortedDictionary<string,dynamic>()
                {
                    //new KeyValuePair<string,object>("Wyrzucenie śmieci",new {Opis = "Wyrzucenie śmieci firmowych", Priorytet = 1}),
                    {"Wyrzucenie śmieci",new {Opis = "ciekawe", Priorytet = 1}},
                    {"Przetarg na długopisy", new {Opis = "100 sztuk", Priorytet = 2}},
                    {"Kupić oprogramowanie dla PIT", new {Opis = "Dla PIT-37", Priorytet = 1}}

                }

            };
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

            Pracownik p3 = new Pracownik("Adam", "Kozioł", new DateTime(2011, 1, 1))
            {
                // DataZatrudnienia = new DateTime(2010,1,1),
                wynagrodzenie = new Wynagrodzenie()
                {
                    Zasadnicze = 3500,
                    Premia = 3000

                },
            };
            Console.WriteLine(p3.Equals(p2));
            Console.WriteLine(p3.CompareTo(p2));


//            Console.WriteLine(p2.imie + " " + p2.nazwisko);
//            Console.WriteLine(p2.dane());
//            Console.WriteLine(p2.ToString());
//            daneOsoba(p2);

//            Osoba klient = new Klient("Adrian","Kozłowski",KlientTyp.indywidualny);
//            daneOsoba(klient);



//                foreach (var tytul in p2.zadania.Keys)
//                {
//                Console.WriteLine(tytul.ToString() + " " + p2.zadania[tytul].Priorytet);
//            };


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