using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string? Street { get; set; }
        [Required]
        [MaxLength(100)]
        public string? City { get; set; }
        [Required]
        [MaxLength(50)]
        public string? State { get; set; } // USA is assumed
        [Required]
        [Display(Name = "Zip Code")]
        [MaxLength(10)] // ex: '12345-6789'
        [Column(TypeName = "varchar(10)")]
        public string? ZipCode { get; set; }
    }
}