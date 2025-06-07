using codeFirstStudenCourse.Data;
using codeFirstStudenCourse.DTOs;
using Microsoft.EntityFrameworkCore;

namespace codeFirstStudenCourse.Services;

public class DbService: IDbService
{
    private readonly codeFirstStudentCourseContext _context;

    public DbService(codeFirstStudentCourseContext context)
    {
        _context = context;
    }

    public async Task<List<EnrollmentDTO>> GetEnrollment()
    {
        return await _context.Enrollments
            .Include(e => e.Course)
            .Include(e => e.Student)
            .Select(e => new EnrollmentDTO
            {
                Student = new StudentDTO
                {
                    Id = e.Student.Id,
                    FirstName = e.Student.FirstName,
                    LastName = e.Student.LastName,
                    Email = e.Student.Email,
                },
                Course = new CourseDTO
                {
                    Id = e.Course.Id,
                    Title = e.Course.Title,
                    Teacher = e.Course.Teacher,
                },
                EnrollmentDate = e.EnrollmentDate,
            })
            .ToListAsync();
    }
}