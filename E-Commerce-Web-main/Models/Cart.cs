

    public class Cart
    {
        public string CartID { get; set; }  // Kiểu dữ liệu string
        public string UserID { get; set; }  // Kiểu dữ liệu string
        public string ProductID { get; set; }  // Kiểu dữ liệu string
        public int Quantity { get; set; }
        public DateTime AddedAt { get; set; } = DateTime.Now;

        public Product Product { get; set; }
        public User User { get; set; }
    }
