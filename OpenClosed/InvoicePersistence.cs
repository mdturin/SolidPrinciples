using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
    interface InvoicePersistence
    {
        public void Save(Invoice invoice);
    }
}
