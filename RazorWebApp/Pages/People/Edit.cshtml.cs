#nullable disable
using Microsoft.AspNetCore.Mvc;

namespace RazorWebApp.Pages.People
{
    public class EditModel : PageModel
    {
        private readonly PeopleContext _db;

        public EditModel(PeopleContext context)
        {
            _db = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            // Used in development to figure out why the modelstate was invalid
            // (It turns out that nested objects [not lists] must be nullable or included in the modelstate)
            //var errors = ModelState
            //    .Where(x => x.Value.Errors.Count > 0)
            //    .Select(x => new { x.Key, x.Value.Errors })
            //    .ToArray();

            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Attach(Person).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PersonExists(Person.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool PersonExists(int id)
        {
            return _db.People.Any(e => e.Id == id);
        }
    }
}
