using System.ComponentModel.DataAnnotations;

namespace StudentManagerApp.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
