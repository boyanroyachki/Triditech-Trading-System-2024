using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Triditech.Data.Models
{
    [Comment("")]
    public class ProductImage
    {
        public ProductImage()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        [Comment("")]
        public Guid Id { get; set; }

        [Comment("")]
        public required Guid ProductId { get; set; }

        [Comment("")]
        public required Product Product { get; set; }

        [MaxLength()]
        [Comment("")]
        public required string ImageUrl { get; set; }
    }
}
