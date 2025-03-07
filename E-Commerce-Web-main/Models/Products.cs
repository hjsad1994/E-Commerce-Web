

    public class Product
    {
        public string ProductID { get; set; }  // Đảm bảo rằng kiểu dữ liệu là string
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }  // Giới hạn số lượng hàng
        public string ImageURL { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        // Mối quan hệ với các bảng khác
        public ICollection<Cart> Carts { get; set; } = new List<Cart>();
        public ICollection<Wishlist> Wishlists { get; set; } = new List<Wishlist>();
        public ICollection<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
    }
