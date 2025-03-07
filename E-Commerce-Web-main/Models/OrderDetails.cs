public class OrderDetail
{
    public string OrderDetailID { get; set; }
    public string OrderID { get; set; }
    public string ProductID { get; set; }
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
    public decimal Total => Quantity * UnitPrice;  // Tính tổng

    // Mối quan hệ
    public Order Order { get; set; }
    public Product Product { get; set; }
}
