using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3_
{
    class Book:Product
    {
        public Book(int no, string name, double price,string genre) : base(no, name, price) 
        {
            this.genre = genre;
        }
        public Book(int no, string name, double price,int count, string genre) : base(no, name, price,count)
        {
            this.genre = genre;
        }
        public string genre;
    }
}
