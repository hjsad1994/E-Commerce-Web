public class ContactUs
{
    public int ContactID { get; set; }  // Khóa chính
    public string UserID { get; set; }  // Tham chiếu đến User

    public string Name { get; set; } = string.Empty;  // Tên người gửi
    public string Email { get; set; } = string.Empty;  // Email người gửi
    public string Message { get; set; } = string.Empty;  // Nội dung tin nhắn
    public DateTime CreatedAt { get; set; } = DateTime.Now;  // Ngày tạo tin nhắn

    // Mối quan hệ với lớp `User`
    public User User { get; set; }
}
