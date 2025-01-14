using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public int OrderID { get; set; }
        public DateTime InvoiceDate { get; set; }
        public bool PaymentMethod { get; set; }  // True: Cash, False: Bank Transfer
        public decimal TotalAmount { get; set; }

        public Order Order { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }

}
