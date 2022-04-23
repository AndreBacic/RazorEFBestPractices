using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Task
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string? Title { get; set; }
        [Required]
        [MaxLength(1023)]
        public string? Description { get; set; }
        [Required]
        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }
        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }
        [Required]
        public int Priority { get; set; }

        public List<Person> People { get; set; } = new();
    }
}
