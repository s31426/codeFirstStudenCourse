using codeFirstStudenCourse.Models;
using Microsoft.EntityFrameworkCore;

namespace codeFirstStudenCourse.Data;

public class codeFirstStudentCourseContext : DbContext
{
    public codeFirstStudentCourseContext(DbContextOptions<codeFirstStudentCourseContext> options) : base(options){}
    public DbSet<Enrollment> Enrollments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<Student> Students { get; set; }
}