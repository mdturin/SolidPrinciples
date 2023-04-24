using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibility
{
    public class InvoicePersistence
    {
        Invoice invoice;

        public InvoicePersistence(Invoice invoice)
        {
            this.invoice = invoice;
        }

        public void SaveToFile(string fileName)
        {
            // saving file with given filename
        }
    }
}
