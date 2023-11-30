using System.ComponentModel.DataAnnotations;

namespace ITI_GProject.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Clientid { get; set; }
        public DateTime? CreatedAt { get; set; }
        public virtual Client? Client { get; set; }
        public virtual ICollection<Product>? Products { get; set; } = new List<Product>();

        public static implicit operator Order(List<Product> v)
        {
            throw new NotImplementedException();
        }
    }
}