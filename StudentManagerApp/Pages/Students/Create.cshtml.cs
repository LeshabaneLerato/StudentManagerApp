using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace StudentManagerApp.Pages.Students
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public string StudentName { get; set; }

        public string Message { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            Message = $"Student '{StudentName}' added successfully!";
        }
    }
}
