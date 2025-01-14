using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public required string CategoryName { get; set; }

        public ICollection<Product> Products { get; set; }
    }

}
