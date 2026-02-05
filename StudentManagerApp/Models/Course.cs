using System.ComponentModel.DataAnnotations;

namespace StudentManagerApp.Models
{
    public class Course
    {
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [MaxLength(200)]
        public string? Title { get; set; }

        public string? Description { get; set; }
    }
}
