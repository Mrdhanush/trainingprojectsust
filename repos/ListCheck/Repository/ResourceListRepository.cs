using AllocateResourceAPI.Data;
using AllocateResourceAPI.Models;

namespace AllocateResourceAPI.Repository
{
    public class ResourceListRepository : IResourceListRepository
    {
        private readonly ResourceAllContext _context;

        public ResourceListRepository(ResourceAllContext context)
        {
            _context = context;
        }

        public IEnumerable<ResourceAllocated> GetAll()
        {
            return _context.ResourceAllocated.ToList();
        }

        public ResourceAllocated GetById(int id)
        {
            return _context.ResourceAllocated.FirstOrDefault(r => r.AllocationId == id);
        }

        public void Add(ResourceAllocated resourceAllocated)
        {
            _context.ResourceAllocated.Add(resourceAllocated);
            _context.SaveChanges();
        }

        public void Update(ResourceAllocated resourceAllocated)
        {
            _context.ResourceAllocated.Update(resourceAllocated);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var resourceAllocated = _context.ResourceAllocated.FirstOrDefault(r => r.AllocationId == id);
            if (resourceAllocated != null)
            {
                _context.ResourceAllocated.Remove(resourceAllocated);
                _context.SaveChanges();
            }
        }
    }
}
