using System.ComponentModel.DataAnnotations;

namespace ITI_GProject.Models
{
    public class Seller
    {
        [Key]
        public int Sellerid { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public virtual ICollection<Product>? SellerProducts { get; set; } = new HashSet<Product>();
    }
}
