using System.ComponentModel.DataAnnotations;

namespace codeFirstStudenCourse.Models;

public class Course
{
    [Key]
    public int Id { get; set; }
    public string Title { get; set; }
    public string Credits { get; set; }
    public string Teacher { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; }
}