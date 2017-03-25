using System;
using System.Collections.Generic;
using Klasy.Properties;


namespace Klasy
{
    internal class Program
    {
        public static void runPunkt()
        {
            Punkt p1 = new Punkt();
            Punkt p2 = new Punkt();

            p1.x = 3;
            p1.y = 4;
            p2.x = 10;
            p2.y = 20;

            p1.Wypisz();
            p2.Wypisz();

            Console.WriteLine(p1.odlegloscOdPoczatkuUWsp());
            Console.WriteLine(p2.odlegloscOdPoczatkuUWsp());

            Console.WriteLine(p1.odlegloscOdPunktu(p2));
            Console.WriteLine(p2.odlegloscOdPunktu(p1));
        }

        public static void runAnimal()
        {
            Lion lion = new Lion(3);
            lion.Age = 1;
            var lionAge = lion.Age;
            Console.WriteLine(lionAge);
        }


        public static void Main(string[] args)
        {
            runAnimal();


        }
    }
}