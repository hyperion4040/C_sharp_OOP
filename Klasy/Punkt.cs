using System;

namespace Klasy
{
    public class Punkt
    {
        public double x = 0, y = 0;

        public void Wypisz()
        {
            Console.WriteLine("({0}, {1})",x,y);
        }



        public double odlegloscOdPoczatkuUWsp()
        {
            return Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2));
        }

        public double odlegloscOdPunktu(Punkt punkt)
        {
            return Math.Sqrt(Math.Pow(Math.Abs(punkt.x - this.x), 2) + Math.Pow(Math.Abs(punkt.y - this.y), 2));
        }

    }
}