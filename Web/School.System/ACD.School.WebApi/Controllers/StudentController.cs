using ACD.School.Services;
using ACD.School.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ACD.School.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService studentService;

        public StudentController(
            IStudentService studentService
            )
        {
            this.studentService = studentService;
        }

        [Route("get-all")]
        [HttpGet]
        public List<StudentViewModel> GetAll()
        {
            return studentService.GetAll();
        }
    }
}