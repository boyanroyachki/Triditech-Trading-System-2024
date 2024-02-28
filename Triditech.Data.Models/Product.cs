using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triditech.Data.Models
{
    [Comment("")]
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
            ProductImages = new List<ProductImage>();
        }

        [Key]
        [Comment("")]
        public Guid Id { get; set; }

        [Comment("")]
        public required string Name { get; set; }

        [Comment("")]
        public required string Description { get; set; }

        [Comment("")]
        public required string Industry { get; set; }

        [Comment("")]
        public required string Material { get; set; }

        [Comment("")]
        public required string Process { get; set; }

        [Comment("")]
        public required string Weight { get; set; }

        [Comment("")]
        public required int CategoryId { get; set; }

        [Comment("")]
        [ForeignKey(nameof(CategoryId))]
        public required Category Category { get; set; }

        [Comment("")]
        public required decimal PriceEuro { get; set; }

        [Comment("")]
        public required Guid VendorId { get; set; }

        [Comment("")]
        [ForeignKey(nameof(VendorId))]
        public required Vendor Vendor { get; set; }

        [Comment("")]
        public virtual ICollection<ProductImage> ProductImages { get; set; }

    }
}
