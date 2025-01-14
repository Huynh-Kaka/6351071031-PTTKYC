using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BTL_WINFORM.Forms;
using Microsoft.EntityFrameworkCore;

namespace BTL_WINFORM.Models.Entities
{
    public class Account
    {
        public int AccountID { get; set; }
        public  string Username { get; set; }
        public  string Password { get; set; }

        public int Role { get; set; } // 1: Admin, 2: Nhân viên

        public  ICollection<Order> Orders { get; set; }
        public  ICollection<Employee> Employees { get; set; }
    }
}

