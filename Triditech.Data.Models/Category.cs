using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Triditech.Common.EntityValidationConstants.Category;

namespace Triditech.Data.Models
{
    [Comment("Product category")]
    public class Category
    {
        public Category()
        {
            Products = new List<Product>();
        }

        [Key]
        [Comment("Product ID")]
        public int Id { get; init; }

        [MaxLength(MaxNameLength)]
        [Comment("Category name")]
        public required string Name { get; set; }

        [Comment("")]
        public List<Product> Products { get; init; } 
    }
}
