#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using EFDataAccess.Models;
using EFDataAccess.DataAccess;

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
        public Person Person { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.People.Add(Person);
            await _db.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
