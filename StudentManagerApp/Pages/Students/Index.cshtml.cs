using Microsoft.AspNetCore.Mvc.RazorPages;
using StudentManagerApp.Models;
using System.Collections.Generic;

namespace StudentManagerApp.Pages.Students
{
    public class IndexModel : PageModel
    {
        public List<Student> Students { get; set; }

        public void OnGet()
        {
            Students = new List<Student>
            {
                new Student { Id = 1, Name = "Lerato" },
                new Student { Id = 2, Name = "Thabo" }
            };
        }
    }
}
