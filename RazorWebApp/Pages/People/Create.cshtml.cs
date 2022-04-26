#nullable disable
using Microsoft.AspNetCore.Mvc;
using RazorWebApp.Models;

namespace RazorWebApp.Pages.People
{
    public class CreateModel : PageModel
    {
        private readonly PeopleContext _db;

        public CreateModel(PeopleContext context)
        {
            _db = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ViewPersonModel Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // put view model data into db model
            var person = new Person();
            person.Id = Person.Id;
            person.FirstName = Person.FirstName;
            person.LastName = Person.LastName;
            person.Age = Person.Age;

            _db.People.Add(person);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
