using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirstDemo2.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public DateTime CreatedOn { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }

    }
}