using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagerApp.Models;
using StudentManagerApp.Data;

namespace StudentManagerApp.Pages.Course
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Models.Course> Courses { get; set; } = new List<Models.Course>();

        public void OnGet()
        {
            Courses = _context.Courses.ToList();
        }
    }
}
