using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3
{
    class Book:Product
    {
        public Book(string genre,int no, string name, double price):base(no ,name,price)
        {
            this.Genre = genre;
        }
        public Book(string genre,int no, string name, double price,int count) : base(no, name, price,count)
        {
            this.Genre = genre;
        }

        public string Genre;
    }
}
