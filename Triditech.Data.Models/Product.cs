using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Triditech.Common.EntityValidationConstants.Product;

namespace Triditech.Data.Models
{
    [Comment("Product table")]
    public class Product
    {
        public Product()
        {
            Id = Guid.NewGuid();
            ProductImages = new List<ProductImage>();
        }

        [Key]
        [Comment("Product ID")]
        public Guid Id { get; set; }

        [Comment("Product's name")]
        [MaxLength(MaxNameLength)]
        public required string Name { get; set; }

        [Comment("Product Description")]
        [MaxLength(MaxDescriptionLength)]
        public required string Description { get; set; }

        [Comment("Product Quantity")]
        public required int Quantity { get; set; }

        [Comment("Product's industry")]
        [MaxLength(MaxIndustryLength)]
        public required string Industry { get; set; }

        [Comment("The material of the Product")]
        [MaxLength(MaxMaterialLength)]
        public required string Material { get; set; }

        [Comment("The process of making of the Product")]
        [MaxLength(MaxProcessNameLength)]
        public required string Process { get; set; }

        [Comment("Product's weight")]
        [MaxLength(MaxWeightLength)]
        public required string Weight { get; set; }

        [Comment("Product's category's ID")]
        public required int CategoryId { get; set; }

        [Comment("Product's Category")]
        [ForeignKey(nameof(CategoryId))]
        public required Category Category { get; set; }

        [Comment("Product's price in EURO")]
        [Column(TypeName = "decimal(18,2)")]
        public required decimal PriceEuro { get; set; }

        [Comment("Product's vendor's ID")]
        public required Guid VendorId { get; set; }

        [Comment("Product's Vendor")]
        [ForeignKey(nameof(VendorId))]
        public required Vendor Vendor { get; set; }

        [Comment("Collection of Images for the product")]
        public virtual List<ProductImage> ProductImages { get; set; }

    }
}
