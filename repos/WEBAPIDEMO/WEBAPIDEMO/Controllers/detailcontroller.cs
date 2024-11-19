using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WEBAPIDEMO.Models;

namespace WEBAPIDEMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class detailcontroller : ControllerBase
    {
        private static List<employe> _emp = new List<employe>()
        {
        new employe { Id =1,Name="dhanush",age = 22},
        new employe { Id=2,Name="vijay",age=40},
        new employe { Id=3,Name="john",age=50}
        };


        [HttpGet]
        public ActionResult<IEnumerable<employe>> Getemplist()
        {
            return _emp;
        }
        [HttpGet("{id}")]
        public ActionResult<employe> Getbyid(int id)
        {
            var employe = _emp.FirstOrDefault(p => p.Id == id);
            if (employe == null)
            {
                return NotFound();
            }
            return employe;
        }
    }
}
