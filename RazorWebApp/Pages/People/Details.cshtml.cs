#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using EFDataAccess.Models;
using EFDataAccess.DataAccess;

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
