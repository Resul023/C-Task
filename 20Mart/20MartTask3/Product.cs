using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3_
{
    class Product
    {
        public Product( int no, string name,double price) 
        {
            this.no = no;
            this.name = name;
            this.price = price;
        }
        public Product(int no, string name, double price, int count) :this(no,name,price)
        {
            this.count = count ;
        }
        public int no;
        public string name;
        public double price;
        public int count;
    }
}
