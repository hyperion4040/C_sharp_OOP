using System;
using System.Collections.Generic;
using EmptyProject;

namespace ConsoleApplication
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pracownik p1 = new Pracownik();

            Console.WriteLine(p1.getDataZatrudnienia());
            p1.setUmowaTyp(UmowaTyp.oPrace);
            Console.WriteLine("Pracownik ma nastepujacy rodzaj umowy " + p1.getUmowaTyp());
        }
    }
}