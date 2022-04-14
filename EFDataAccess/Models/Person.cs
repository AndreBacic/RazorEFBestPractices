using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(75)]
        public string LastName { get; set; }
        [Required]
        public int Age { get; set; }
        public List<Email> Emails { get; set; } = new();
        public Address Address { get; set; } = new();
        public List<Task> Tasks { get; set; } = new();
    }
}
