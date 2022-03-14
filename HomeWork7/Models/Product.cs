using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7.Models
{
    internal class Product
    {
        public int no;
        public string name;
        public double price;
        public int count;

        public Product(int no, string name, double price)
        {
            this.no = no;
            this.name = name;
            this.price = price;
        }
    }
}
