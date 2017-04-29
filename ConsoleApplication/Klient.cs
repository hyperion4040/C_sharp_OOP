namespace ConsoleApplication
{
    public class Klient : Osoba
    {

        private KlientTyp typ;
    }

    enum KlientTyp
    {
        firma, indywidualny, instytucjonalny
    }
}