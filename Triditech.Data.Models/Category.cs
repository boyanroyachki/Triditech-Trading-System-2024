using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Triditech.Common.EntityValidationConstants.Category;

namespace Triditech.Data.Models
{
    [Comment("")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        [Comment("")]
        public int Id { get; init; }

        [MaxLength(MaxNameLength)]
        [Comment("")]
        public required string Name { get; set; }

        [Comment("")]
        public ICollection<Product> Products { get; init; } 
    }
}
