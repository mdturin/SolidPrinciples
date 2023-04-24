using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class DatabasePersistence : InvoicePersistence
    {
        public void Save(Invoice invoice)
        {
            // save file in database
            Console.WriteLine("Saved in db!");
        }
    }
}
