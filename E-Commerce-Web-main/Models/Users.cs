using Microsoft.AspNetCore.Identity;

public class User : IdentityUser
{
    public ICollection<Cart> Carts { get; set; }
    public ICollection<Wishlist> Wishlists { get; set; }
    public ICollection<Order> Orders { get; set; }
    public ICollection<ContactUs> ContactUs { get; set; }  // Mối quan hệ với ContactUs

}
