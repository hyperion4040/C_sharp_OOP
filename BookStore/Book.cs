using System;



namespace BookStore
{


    public class Book : IBook
    {
        public delegate void bookDelegate(string message);

        public delegate String bookDelegateSecond();

        public event bookDelegateSecond bookEvent;


        private string title;
        private string author;
        private int numberOfBooks;
        private int numberOfPages;

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public int NumberOfBooks
        {
            get { return numberOfBooks; }
            set
            {
                if(value > -1)
                numberOfBooks = value;
                else
                {
                    throw new Exception("Number of book can't be smaller than 0");
                }
            }
        }

        public Book(string title, string author, int numberOfBooks,int numberOfPages)
        {
            this.title = title;
            this.author = author;
            this.numberOfBooks = numberOfBooks;
            this.numberOfPages = numberOfPages;
        }

        protected Book()
        {

        }

        public void countSumOfPagesOfAllBooks(string name)
        {
            Console.WriteLine("{0}, your book has {1} pages",name, this.numberOfPages );

        }

        public string nameOfBook()
        {
            return "This book title is " + title;
        }

        public string numberOfPagesLessThanZero()
        {
            if (numberOfPages < 0 && bookEvent != null)
            {
                return bookEvent();
            }
            else
            {
                return "Number of book pages is ok";
            }
        }

        public string eventMessage()
        {
            return "Book can't have less than 0 pages. Info from event";
        }

    }
}