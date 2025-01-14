using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public required  string ProductName { get; set; }
        public required  int CategoryID { get; set; }
        public required  decimal Price { get; set; }

        //public int Quantity { get; set; } = 0; // Adding default value for Quantity
        //public string Description { get; set; }
        public string Image { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<InvoiceDetail> InvoiceDetails { get; set; }
    }

}
