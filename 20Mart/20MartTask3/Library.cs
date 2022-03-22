using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3_
{
    class Library
    {
        public Book[] books;
        int j = 0;
        public void AddBook(Book book) 
        {
            books[j++] = book;
        }
        
        public Book[] GetFilteredBook(string genre) 
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.genre == genre)
                {
                    count++;
                }
            }

            Book[] NewBook = new Book[count];
            int CountTwo = 0;
            foreach (var item in books)
            {
                if (item.genre == genre)
                {
                    NewBook[CountTwo++] = item;

                }
            }return NewBook;
        }
        public Book[] GetFilteredBook(double MinPrice, double MaxPrice) 
        {
            int count = 0;
            foreach (var item in books)
            {
                if (item.price>MinPrice && item.price<MaxPrice)
                {
                    count++;
                }
            }
            Book[] NewBook = new Book[count];
            int CountTwo =0 ;

            foreach (var item in books)
            {
                if (item.price > MinPrice && item.price < MaxPrice)
                {
                    NewBook[CountTwo++] = item;
                }
            }return NewBook;





        }

        public void GetInfo(Book[] books) 
        {
            foreach (var item in books)
            {
                Console.WriteLine($"Name-{item.name} Price-{item.price} No-{item.no} Count-{item.count} Genre-{item.genre}");
            }
        }


    }
}
