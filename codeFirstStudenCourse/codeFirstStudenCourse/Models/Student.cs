using System.ComponentModel.DataAnnotations;

namespace codeFirstStudenCourse.Models;

public class Student
{
    [Key]
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    
    public ICollection<Enrollment> Enrollments { get; set; }
}