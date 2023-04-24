using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Book
    {
        public string name;
        public string authorName;
        public int year;
        public int price;
        public string isbn;

        public Book(string name, string authorName, int year, int price, string isbn)
        {
            this.name = name;
            this.authorName = authorName;
            this.year = year;
            this.price = price;
            this.isbn = isbn;
        }
    }
}
