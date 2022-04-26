#nullable disable
using Microsoft.AspNetCore.Mvc;

namespace RazorWebApp.Pages.People
{
    public class DetailsModel : PageModel
    {
        private readonly PeopleContext _db;

        public DetailsModel(PeopleContext context)
        {
            _db = context;
        }

        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _db.People.Where(m => m.Id == id)
                                     .Include(p => p.Tasks)
                                     .FirstOrDefaultAsync();

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
