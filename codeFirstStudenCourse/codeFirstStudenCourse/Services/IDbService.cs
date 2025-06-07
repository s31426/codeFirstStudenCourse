using codeFirstStudenCourse.DTOs;

namespace codeFirstStudenCourse.Services;

public interface IDbService
{
    Task<List<EnrollmentDTO>> GetEnrollment();
}