using System.Linq;

namespace BookStore
{
    public class FantasyBook : Book
    {
        public FantasyBook(string title, string author, int numberOfBooks, int numberOfPages) : base(title, author, numberOfBooks, numberOfPages)
        {
            this.Author = author;
            this.NumberOfBooks = numberOfBooks;
            this.NumberOfPages = numberOfPages;
            this.Title = title;
        }

        protected FantasyBook()
        {
        }




    }
}