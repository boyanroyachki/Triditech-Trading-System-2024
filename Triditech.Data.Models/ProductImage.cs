using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Triditech.Data.Models
{
    [Comment("Images for the products")]
    public class ProductImage
    {
        public ProductImage()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("Image's ID")]
        public Guid Id { get; set; }

        [Comment("Image's Product's ID")]
        public Guid ProductId { get; set; }

        [Comment("Image's Product")]
        [ForeignKey(nameof(ProductId))]
        public Product Product { get; set; }

        [Comment("Image's URL")]
        [MaxLength()]
        public required string ImageUrl { get; set; }
    }
}
