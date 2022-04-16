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

        public void OnGet(int minAge = 0, int maxAge = 150)
        {
            LoadSampleData();

            People = _db.People
                .Include(p => p.Address)
                .Include(p => p.Emails)
                .Where(p => p.Age >= minAge && p.Age <= maxAge)
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
                
                //// Add 1-5 people to each project
                //var allPeople = _db.People.ToList();
                //foreach (var p in _db.Tasks)
                //{
                //    int numPeople = new Random().Next(1, 5);

                //    var tasks = allPeople.OrderBy(x => Guid.NewGuid()).Take(numPeople).ToList();
                //    p.People.AddRange(tasks);
                //}
                //_db.SaveChanges();
            }
        }
    }
}