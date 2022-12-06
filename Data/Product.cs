using Capstone.Utilities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Capstone.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string BaseName { get; set; }
        public double BasePrice { get; set; }
        public string Description { get; set; }
        public int Stocks { get; set; }
        public bool IsActive { get; set; }
        public ProductCategory Category { get; set; }
        [ForeignKey("ProductBaseImages")] public ProductBaseImage BaseImage { get; set; }
        [ForeignKey("ProductPromoImages")] public ProductPromoImage PromoImage { get; set; }
        public ICollection<ProductOrder> ProductOrders { get; set; } 
        public ICollection<CartProduct> CartProducts { get; set; } 
    }
}
