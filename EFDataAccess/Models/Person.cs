using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDataAccess.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Email> Emails { get; set; } = new();
        public Address Address { get; set; } = new();
        public List<Task> Tasks { get; set; } = new();
    }
}
