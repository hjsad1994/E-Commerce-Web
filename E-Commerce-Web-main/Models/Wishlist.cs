public class Wishlist
{
    public string WishlistID { get; set; }  // Kiểu dữ liệu string
    public string UserID { get; set; }  // Kiểu dữ liệu string
    public string ProductID { get; set; }  // Kiểu dữ liệu string
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    public Product Product { get; set; }
    public User User { get; set; }
}
