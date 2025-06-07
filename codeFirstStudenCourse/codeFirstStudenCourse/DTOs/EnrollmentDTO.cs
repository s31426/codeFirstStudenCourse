namespace codeFirstStudenCourse.DTOs;

public class EnrollmentDTO
{
    public StudentDTO Student { get; set; }
    public CourseDTO Course { get; set; }
    public DateTime EnrollmentDate { get; set; }
}

public class CourseDTO
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Teacher { get; set; }
}

public class StudentDTO
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
}