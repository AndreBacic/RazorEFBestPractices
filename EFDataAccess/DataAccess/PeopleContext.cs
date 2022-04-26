using EFDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using Task = EFDataAccess.Models.Task;

namespace EFDataAccess.DataAccess
{
    public class PeopleContext : DbContext
    {
        public PeopleContext(DbContextOptions options) : base(options) { }
        public DbSet<Person> People { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Task> Tasks { get; set; }
    }
}
