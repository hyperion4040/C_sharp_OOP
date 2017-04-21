using System;
using System.Collections.Generic;
using BookStore;

namespace BookStoreMain
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Book book = new Book("Tolkien","Hobbit",12,1250);
            bookDelegate bookDelegate = new bookDelegate(book.countSumOfPagesOfAllBooks);
            bookDelegate("Adrian");
            bookDelegateSecond bookDelegateSecond = new bookDelegateSecond(book.nameOfBook);
            Console.WriteLine(bookDelegateSecond.Invoke());
        }
    }
}