using System.ComponentModel.DataAnnotations;
using StudentManagerApp.Data;
namespace StudentManagerApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
