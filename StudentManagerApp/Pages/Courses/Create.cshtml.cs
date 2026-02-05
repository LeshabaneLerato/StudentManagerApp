using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagerApp.Models;
using StudentManagerApp.Data;

namespace StudentManagerApp.Pages.Course
{
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public CreateModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Course Course { get; set; } = new();

        public void OnPost()
        {
            if (!ModelState.IsValid)
                return;

            _context.Courses.Add(Course);
            _context.SaveChanges();
        }
    }
}
