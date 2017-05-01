using System;
using Firma.Pracownicy;

//using Pracownicy.ConsoleApplication;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Firma.Pracownicy.Pracownik p1 = new Firma.Pracownicy.Pracownik();

            Console.WriteLine("Data zatrudnienia pracownika to: " + p1.pobierzDataZatrudnienia());
            p1.setUmowaTyp(UmowaTyp.oPrace);
            Console.WriteLine("Pracownik ma nastepujacy rodzaj umowy " + p1.getUmowaTyp());
        }

    }
}