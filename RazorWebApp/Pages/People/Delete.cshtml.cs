#nullable disable
using Microsoft.AspNetCore.Mvc;

namespace RazorWebApp.Pages.People
{
    public class DeleteModel : PageModel
    {
        private readonly PeopleContext _db;

        public DeleteModel(PeopleContext context)
        {
            _db = context;
        }

        [BindProperty(SupportsGet = true)]
        public Person Person { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _db.People.FirstOrDefaultAsync(m => m.Id == id);

            if (Person == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Person = await _db.People.FindAsync(id);

            if (Person != null)
            {
                _db.People.Remove(Person);
                await _db.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
