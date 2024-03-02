using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Triditech.Common.EntityValidationConstants.Vendor;

namespace Triditech.Data.Models
{
    [Index(nameof(PhoneNumber), IsUnique = true)]
    [Comment("Vendor of products")]
    public class Vendor
    {
        public Vendor()
        {
            Id = Guid.NewGuid();
            Products = new List<Product>();
        }

        [Key]
        [Comment("Vendor identifier")]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(MaxVendorsPhoneLength)]
        [Comment("Vendor's phone")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        [Comment("User Identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

        public List<Product> Products { get; set; }
    }
}
