using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFDataAccess.Models
{
    [Table("Emails")]
    public class Email
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(200)]
        public string EmailAddress { get; set; }
    }
}
