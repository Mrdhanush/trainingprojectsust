using AUTHORIZE.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AuthDemoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        // Public endpoint - no authorization required
        [HttpGet]
        public IActionResult GetProducts()
        {
            return Ok(new List<string> { "Product1", "Product2", "Product3" });
        }

        // Authenticated users only
        [HttpPost]
        [Authorize]
        public IActionResult CreateProduct([FromBody] Product product)
        {
            return Ok(new { Message = "Product created successfully", Product = product });
        }

        // Admin role only
        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult DeleteProduct(int id)
        {
            return Ok(new { Message = $"Product with ID {id} deleted successfully" });
        }
    }

    // Sample Product class
 
}
