using dacs.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : IdentityDbContext<User>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    // DbSet cho các bảng trong cơ sở dữ liệu
    public DbSet<Category> Categories { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetail> OrderDetails { get; set; }
    public DbSet<Cart> Carts { get; set; }
    public DbSet<Wishlist> Wishlists { get; set; }
    public DbSet<Payment> Payments { get; set; }
    public DbSet<ContactUs> ContactUs { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Cấu hình các mối quan hệ giữa các bảng
        modelBuilder.Entity<Cart>()
            .HasOne(c => c.Product)
            .WithMany(p => p.Carts)
            .HasForeignKey(c => c.ProductID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Cart>()
            .HasOne(c => c.User)
            .WithMany(u => u.Carts)
            .HasForeignKey(c => c.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Wishlist>()
            .HasOne(w => w.User)
            .WithMany(u => u.Wishlists)
            .HasForeignKey(w => w.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Wishlist>()
            .HasOne(w => w.Product)
            .WithMany(p => p.Wishlists)
            .HasForeignKey(w => w.ProductID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Order>()
            .HasOne(o => o.User)
            .WithMany(u => u.Orders)
            .HasForeignKey(o => o.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Order)
            .WithMany(o => o.OrderDetails)
            .HasForeignKey(od => od.OrderID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<OrderDetail>()
            .HasOne(od => od.Product)
            .WithMany(p => p.OrderDetails)
            .HasForeignKey(od => od.ProductID)
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Payment>()
            .HasOne(p => p.Order)
            .WithMany(o => o.Payments)
            .HasForeignKey(p => p.OrderID)
            .OnDelete(DeleteBehavior.Cascade);

        // Cấu hình ContactUs với User
        modelBuilder.Entity<ContactUs>()
            .HasKey(cu => cu.ContactID); // Thiết lập ContactID là khóa chính

        modelBuilder.Entity<ContactUs>()
            .HasOne(cu => cu.User)
            .WithMany(u => u.ContactUs)
            .HasForeignKey(cu => cu.UserID)
            .OnDelete(DeleteBehavior.Cascade);

        // Cấu hình precision và scale cho các thuộc tính kiểu decimal
        modelBuilder.Entity<Product>()
            .Property(p => p.Price)
            .HasColumnType("decimal(18,2)");  // Precision = 18, Scale = 2

        modelBuilder.Entity<Order>()
            .Property(o => o.TotalAmount)
            .HasColumnType("decimal(18,2)");  // Precision = 18, Scale = 2

        modelBuilder.Entity<OrderDetail>()
            .Property(od => od.UnitPrice)
            .HasColumnType("decimal(18,2)");  // Precision = 18, Scale = 2


        // Cấu hình các quan hệ nếu có, ở đây không có quan hệ giữa bảng Customer và bảng khác.
        modelBuilder.Entity<Customer>()
            .Property(c => c.CustomerID)
            .HasMaxLength(50) // Đảm bảo độ dài tối đa cho CustomerID
            .IsRequired();  // Đảm bảo CustomerID là bắt buộc
    }
}
