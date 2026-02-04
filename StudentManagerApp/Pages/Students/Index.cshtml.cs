using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagerApp.Data;
using StudentManagerApp.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace StudentManagerApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly ApplicationDbContext _context;

        public IndexModel(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> Students { get; set; }

        // 🔍 Search term from URL
        [BindProperty(SupportsGet = true)]
        public string SearchTerm { get; set; }

        public async Task OnGetAsync()
        {
            // Start query
            var query = _context.Students.AsQueryable();

            // Apply filter if user typed something
            if (!string.IsNullOrEmpty(SearchTerm))
            {
                query = query.Where(s =>
                    s.Name.Contains(SearchTerm));
            }

            Students = await query.ToListAsync();
        }
    }
}
