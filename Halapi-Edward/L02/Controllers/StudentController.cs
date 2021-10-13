using System;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Lab02.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Student Get()
        {
            StudentRepo stud = new StudentRepo();
            return stud.student[0];
        }
        public Student Delete()
        {
            StudentRepo stud = new StudentRepo();
            return null;
        }
    }
}
