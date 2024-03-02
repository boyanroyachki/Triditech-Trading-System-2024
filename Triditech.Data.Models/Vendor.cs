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

        [MaxLength(MaxVendorsPhoneLength)]
        [Comment("Vendor's phone")]
        public required string PhoneNumber { get; set; }

        [Comment("User Identifier")]
        public required string UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        [Comment("Vendor's Application User")]
        public required IdentityUser User { get; set; }

        [Comment("The collection of the vendor's products")]
        public List<Product> Products { get; set; }
    }
}
