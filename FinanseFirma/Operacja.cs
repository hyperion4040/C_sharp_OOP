using System;

namespace Firma.Finanse //ConsoleApplication
{
    public class Operacja
    {
        public decimal kwota;
        public DateTime data;
        public string tytul;
        public bool rozliczneie;


        ~Operacja()
        {
            Console.WriteLine("Usunięto obiekt operacja" + this.GetHashCode());
        }
    }
}