using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class Invoice
    {
        public Book book;
        public int quantity;
        public double discountRate;
        public double taxRate;
        public double total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
            this.total = this.CalculateTotal();
        }

        public double CalculateTotal()
        {
            double price = (book.price - book.price * discountRate) * quantity;
            double priceWithTax = price * (1 + taxRate);
            return priceWithTax;
        }
    }
}
