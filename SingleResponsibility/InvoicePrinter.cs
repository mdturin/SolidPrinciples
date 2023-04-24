using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class InvoicePrinter
    {
        private Invoice invoice;

        public InvoicePrinter(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void Print()
        {
            Console.WriteLine($"{invoice.quantity} x {invoice.book.name} {invoice.book.price}$");
            Console.WriteLine($"Discount Rate: {invoice.discountRate}");
            Console.WriteLine($"Tax Rate: {invoice.taxRate}");
            Console.WriteLine($"Total: {invoice.total}");
        }
    }
}
