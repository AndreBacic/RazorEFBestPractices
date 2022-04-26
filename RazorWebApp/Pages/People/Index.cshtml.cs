#nullable disable

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
