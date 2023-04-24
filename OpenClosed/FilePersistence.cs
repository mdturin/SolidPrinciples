using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    public class FilePersistence : InvoicePersistence
    {
        public void Save(Invoice invoice)
        {
            // save in file
            Console.WriteLine("Saved in file!");
        }
    }
}
