using System;
using System.Collections.Generic;
using BookStore;

namespace BookStoreMain
{
    internal class Program
    {
        public static void Main(string[] args)
        {
//            Book book = new Book("Tolkien","Hobbit",12,1250);
//            Book.bookDelegate bookDelegate = new Book.bookDelegate(book.countSumOfPagesOfAllBooks);
//            bookDelegate("Adrian");
//            Book.bookDelegateSecond bookDelegateSecond = new Book.bookDelegateSecond(book.nameOfBook);
//            Console.WriteLine(bookDelegateSecond.Invoke());

            Book bookEv = new Book("Tolkien","Lotr",2,-20);
            bookEv.bookEvent += new Book.bookDelegateSecond(bookEv.eventMessage);
             Console.WriteLine(bookEv.numberOfPagesLessThanZero());

        }
    }
}