namespace BookStore
{
    public interface IBook
    {
        void countSumOfPagesOfAllBooks(string name);
        string nameOfBook();
        string numberOfPagesLessThanZero();
        string eventMessage();



    }
}