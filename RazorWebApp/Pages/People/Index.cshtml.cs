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
    public class IndexModel : PageModel
    {
        private readonly PeopleContext _db;

        public IndexModel(PeopleContext context)
        {
            _db = context;
        }

        public IList<Person> Person { get; set; }

        public void OnGetAsync()
        {
            Person = _db.People.ToList();
        }
    }
}
