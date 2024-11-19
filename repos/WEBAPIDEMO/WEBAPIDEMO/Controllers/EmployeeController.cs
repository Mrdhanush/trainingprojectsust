using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPIDEMO.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        [HttpGet]
        public string GetString()
        {
            return "Hello";
        }
        [HttpGet]
        public string get()
        {
            return "employee";
        }

    }
}
