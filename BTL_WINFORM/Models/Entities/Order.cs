using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Order
    {
        public int OrderID { get; set; }
        public required int CustomerID { get; set; }
        public required int AccountID { get; set; }
        public required int TableID { get; set; }
        public DateTime OrderDate { get; set; }

        public Customer Customer { get; set; }
        public required Account Account { get; set; }
        public Table Table { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }

        public ICollection<Invoice> Invoices { get; set; }
    }

}
