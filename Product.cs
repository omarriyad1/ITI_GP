using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_GProject.Models
{
    public class Product
    {
        [Key]
        public int Productid { get; set; }
        public string? Prodname { get; set; } = string.Empty;
        public string? Proddescription { get; set; } = string.Empty;
        public decimal? Price { get; set; }
        public string? image { get; set; } = string.Empty;
        [ForeignKey("Seller")]
        public int Sellerid { get; set; }
        public virtual Seller? Seller { get; set; }


    }
}
