using System;
using System.Collections.Generic;
using System.Text;

namespace _20MartTask3
{
    class Product
    { public Product(int no,string name,double price) 
        {
            this.no = no;
            this.Name = name;
            this.Price = price;
        }
        public Product(int no, string name, double price,int count):this(no,name,price)
        {
            this.Count = count;
        }
        public int no;
        public string Name;
        public double Price;
        public int Count;
    }
}
