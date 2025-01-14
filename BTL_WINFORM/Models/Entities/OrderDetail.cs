using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }
        public required int OrderID { get; set; }
        public required int ProductID { get; set; }
        public required int Quantity { get; set; }// soos luong

        public Order Order { get; set; }
        public Product Product { get; set; }
    }

}
