using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ITI_GProject.Models
{
    public class Cart
    {

        public static List<Product> Products { get; set; } = new List<Product>();


    }


}



