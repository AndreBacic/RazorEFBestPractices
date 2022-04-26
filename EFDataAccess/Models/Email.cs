using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccess.Models
{
    [Table("Emails")]
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Email Address")]
        [MaxLength(200)]
        public string? EmailAddress { get; set; }
    }
}
