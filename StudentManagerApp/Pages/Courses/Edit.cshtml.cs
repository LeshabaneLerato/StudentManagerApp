
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagerApp.Data;
using StudentManagerApp.Models;

namespace LearnerManagementSystem.Pages.Courses
{
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public EditModel(ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Course Course { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Course = await _context.Courses.FindAsync(id);

            if (Course == null)
                return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            _context.Courses.Update(Course);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
