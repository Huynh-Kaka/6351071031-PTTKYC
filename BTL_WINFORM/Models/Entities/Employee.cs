using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_WINFORM.Models.Entities
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public int AccountID { get; set; }
        public string FullName { get; set; }
        public string Position { get; set; }
        public DateTime DateOfJoining { get; set; } // Ngày vào làm
        public string Status { get; set; } = "Active"; // Trạng thái
        public decimal Salary { get; set; } // Lương
        public DateTime CreatedAt { get; set; } = DateTime.Now; // Ngày tạo
        public DateTime UpdatedAt { get; set; } = DateTime.Now; // Ngày cập nhật

        // Navigation property
        public Account Account { get; set; }
    }

}
