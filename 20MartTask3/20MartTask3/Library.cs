using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3
{
    class Library 
    {
        public Book[] books;
        int j = 0;
        public void AddBook(Book book) 
        {
            books[j++] = book ;
        }
        public Book[] GetFilteredBooks(string genre) 
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.Genre == genre)
                {
                    count++;
                }
            }
            Book[] NewBook = new Book[count];
            int CountTwo = 0;
            foreach (var item in books)
            {
                if (item.Genre == genre)
                {
                    NewBook[CountTwo++].Genre = genre;

                }
            }return NewBook;
        }
        public Book[] GetFilteredBooks(double MaxPrice, double MinPrice) 
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.Price>MinPrice && item.Price<MaxPrice)
                {
                    count++;
                }
            }
            Book[] NewBooks = new Book[count];
            int CountTwo = 0;
            foreach (var item in books)
            {
                if (item.Price > MinPrice && item.Price < MaxPrice)
                {
                    NewBooks[CountTwo++] = item;
                }
            } return NewBooks;

        }
        public void GetInfo(Book[] book)
        {
            foreach (var item in book)
            {
                Console.WriteLine($"Name- {item.Name} Genre- {item.Genre} Price- {item.Price} No- {item.No}");
            }
            
        }
    }
}
