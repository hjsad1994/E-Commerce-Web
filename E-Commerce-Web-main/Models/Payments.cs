public class Payment
{
    public int PaymentID { get; set; }
    public string OrderID { get; set; }
    public string PaymentMethod { get; set; } = string.Empty;  // Khởi tạo giá trị mặc định
    public string PaymentStatus { get; set; } = "pending";  // Giá trị mặc định
    public string TransactionID { get; set; } = string.Empty;  // Khởi tạo giá trị mặc định
    public DateTime? PaidAt { get; set; }

    // Mối quan hệ
    public Order Order { get; set; }
}
