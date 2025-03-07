using System;

namespace dacs.Models
{
    public class Customer
    {
        public string CustomerID { get; set; }  // Sử dụng kiểu string cho ID
        public string FullName { get; set; }    // Tên khách hàng
        public string Email { get; set; }       // Email của khách hàng
        public string PhoneNumber { get; set; } // Số điện thoại
        public DateTime CreatedAt { get; set; } = DateTime.Now;  // Thời gian tạo khách hàng
    }
}
