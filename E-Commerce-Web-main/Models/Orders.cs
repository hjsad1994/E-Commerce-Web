public class Order
{
    public string OrderID { get; set; }
    public string UserID { get; set; }
    public decimal TotalAmount { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string Status { get; set; } = "pending";  // Giá trị mặc định

    // Mối quan hệ
    public User User { get; set; }
    public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();  // Khởi tạo danh sách
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();  // Khởi tạo danh sách
}
