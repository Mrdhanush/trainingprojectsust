using System.Collections.Generic;
using System.Threading.Tasks;
using AllocateResourceAPI.Models;
using AllocateResourceAPI.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AllocateResourceAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ListController : ControllerBase
    {
        private readonly IResourceListRepository _repository;

        public ListController(IResourceListRepository repository)
        {
            _repository = repository;
        }

        // GET: api/List
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ResourceAllocated>>> GetResources()
        {
            var resources = await Task.Run(() => _repository.GetAll());
            return Ok(resources);
        }

        // GET: api/List/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<ResourceAllocated>> GetResource(int id)
        {
            var resource = await Task.Run(() => _repository.GetById(id));
            if (resource == null)
            {
                return NotFound($"Resource with ID {id} not found.");
            }

            return Ok(resource);
        }

        // PUT: api/List/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateResource(int id, ResourceAllocated resourceAllocated)
        {
            if (id != resourceAllocated.AllocationId)
            {
                return BadRequest("Resource ID mismatch.");
            }

            var existingResource = await Task.Run(() => _repository.GetById(id));
            if (existingResource == null)
            {
                return NotFound($"Resource with ID {id} not found.");
            }

            try
            {
                await Task.Run(() => _repository.Update(resourceAllocated));
            }
            catch (DbUpdateConcurrencyException)
            {
                // Handle concurrency issues
                return StatusCode(500, "A concurrency error occurred.");
            }

            return NoContent();
        }

        // POST: api/List
        [HttpPost]
        public async Task<ActionResult<ResourceAllocated>> AddResource(ResourceAllocated resourceAllocated)
        {
            if (resourceAllocated == null)
            {
                return BadRequest("Invalid resource data.");
            }

            await Task.Run(() => _repository.Add(resourceAllocated));
            return CreatedAtAction(nameof(GetResource), new { id = resourceAllocated.AllocationId }, resourceAllocated);
        }

        // DELETE: api/List/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResource(int id)
        {
            var resource = await Task.Run(() => _repository.GetById(id));
            if (resource == null)
            {
                return NotFound($"Resource with ID {id} not found.");
            }

            await Task.Run(() => _repository.Delete(id));
            return NoContent();
        }
    }
}
