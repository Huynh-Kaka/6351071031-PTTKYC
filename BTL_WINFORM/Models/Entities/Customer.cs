using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BTL_WINFORM.Models.Entities
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FullName { get; set; }
        public string Phone { get; set; }

        public ICollection<Order> Orders { get; set; }
    }

}
