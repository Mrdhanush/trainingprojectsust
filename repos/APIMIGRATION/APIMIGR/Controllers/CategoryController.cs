using APIMIGR.Models;
using APIMIGR.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Transactions;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace APIMIGR.Controllers
{
    [Route("api/[controller]")]

    [ApiController]

    public class CategoryController : ControllerBase

    {

        private readonly ICategoryRepository _categorytRepository;

        public CategoryController(ICategoryRepository categoryRepository)

        {

            _categoryRepository = categoryRepository;

        }

        // GET: api/Product

        [HttpGet]

        public IActionResult Get()

        {

            var products = _categoryRepository.GetProducts();

            return new OkObjectResult(products);

        }

        // GET: api/Product/5

        [HttpGet("{id}", Name = "Get")]

        public IActionResult Get(int id)

        {

            var product = _categoryRepository.GetProductByID(id);

            return new OkObjectResult(product);

        }

        // POST: api/Product

        [HttpPost]

        public IActionResult Post([FromBody] Product product)

        {

            using (var scope = new TransactionScope())

            {

                _categoryRepository.InsertProduct(product);

                scope.Complete();

                return CreatedAtAction(nameof(Get), new { id = product.Id }, product);

            }

        }

        // PUT: api/Product/5

        [HttpPut]

        public IActionResult Put([FromBody] Product product)

        {

            if (product != null)

            {

                using (var scope = new TransactionScope())

                {

                    _categoryRepository.UpdateProduct(category);

                    scope.Complete();

                    return new OkResult();

                }

            }

            return new NoContentResult();

        }

        // DELETE: api/ApiWithActions/5

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)

        {

            _categoryRepository.DeleteProduct(id);

            return new OkResult();

        }

    }
}
