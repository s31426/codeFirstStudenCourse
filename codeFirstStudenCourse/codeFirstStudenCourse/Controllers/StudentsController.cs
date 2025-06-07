using codeFirstStudenCourse.Data;
using codeFirstStudenCourse.Services;
using Microsoft.AspNetCore.Mvc;

namespace codeFirstStudenCourse.Controllers;

[ApiController]
[Route("api/enrollments")]
public class StudentsController : ControllerBase
{
    
    private readonly IDbService _dbService;
    
    public StudentsController(IDbService dbService)
    {
        _dbService = dbService;
    }
    
    [HttpGet]
    public async Task<IActionResult> GetEnrollments()
    {
        var result = await _dbService.GetEnrollment();
        return Ok(result);
    }
}