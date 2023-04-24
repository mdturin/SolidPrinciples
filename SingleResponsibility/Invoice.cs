using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class Invoice
    {
        private Book book;
        private int quantity;
        private double discountRate;
        private double taxRate;
        private double total;

        public Invoice(Book book, int quantity, double discountRate, double taxRate)
        {
            this.book = book;
            this.quantity = quantity;
            this.discountRate = discountRate;
            this.taxRate = taxRate;
            this.total = this.calculateTotal();
        }

        public double calculateTotal()
        {
            double price = (book.price - book.price * discountRate) * quantity;
            double priceWithTax = price * (1 + taxRate);
            return priceWithTax;
        }

        public void printInvoice()
        {
            Console.WriteLine($"{quantity} x {book.name} {book.price}$");
            Console.WriteLine($"Discount Rate: {discountRate}");
            Console.WriteLine($"Tax Rate: {taxRate}");
            Console.WriteLine($"Total: {total}");
        }

        public void saveToFile(string fileName)
        {
            // saving file with given filename
        }
    }
}
