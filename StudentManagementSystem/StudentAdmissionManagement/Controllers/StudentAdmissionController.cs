using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentAdmissionManagement.Models;

namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<StudentAdmissionDetails> Get()
        {

        }
    }
}
