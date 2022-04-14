using EFDataAccess.DataAccess;
using EFDataAccess.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace RazorWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly PeopleContext _db;

        public IList<Person> People { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PeopleContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet(int age = 0)
        {
            LoadSampleData();

            People = _db.People
                .Include(p => p.Address)
                .Include(p => p.Emails)
                .Where(p => p.Age > age)
                .ToList();
        }
        
        private void LoadSampleData()
        {
            if (_db.People.Count() == 0)
            {
                string file = System.IO.File.ReadAllText("generated.json");
                var people = JsonSerializer.Deserialize<List<Person>>(file);
                _db.AddRange(people);
                _db.SaveChanges();
            }
        }
    }
}