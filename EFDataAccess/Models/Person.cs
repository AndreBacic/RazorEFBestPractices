using System.ComponentModel.DataAnnotations;

namespace EFDataAccess.Models
{
    public class Person
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
        public List<Email> Emails { get; set; } = new();
        public Address? Address { get; set; }
        public List<Task> Tasks { get; set; } = new();
    }
}
