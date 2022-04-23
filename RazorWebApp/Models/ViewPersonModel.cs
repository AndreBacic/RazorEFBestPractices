using System.ComponentModel.DataAnnotations;

namespace RazorWebApp.Models
{
    public class ViewPersonModel
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First Name")]
        [MaxLength(50)]
        public string? FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        [MaxLength(75)]
        public string? LastName { get; set; }
        [Required]
        public int Age { get; set; }
    }
}
