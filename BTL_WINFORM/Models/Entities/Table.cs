using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Table
    {
        public int TableID { get; set; }
        public string TableName { get; set; }
        public int Capacity { get; set; }
        public required  bool Status { get; set; }  // True: Available, False: Reserved

        public ICollection<Order> Orders { get; set; }
    }

}
