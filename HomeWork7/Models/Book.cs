using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork7.Models
{
    internal class Book : Product
    {
        public string genre;

        public Book(string genre, int no, string name, double price) : base(no, name, price)
        {
            this.genre = genre;
        }
        public string GetInfo()
        {
            return $"\nNo: {no} \nName: {name} \nGenre: {genre} \nPrice: {price} AZN \nCount: {count}";
        }
    }
}
