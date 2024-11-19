using AllocateResourceAPI.Models;

namespace AllocateResourceAPI.Repository
{
    public interface IResourceListRepository
    {
        IEnumerable<ResourceAllocated> GetAll();
        ResourceAllocated GetById(int id);
        void Add(ResourceAllocated resourceAllocated);
        void Update(ResourceAllocated resourceAllocated);
        void Delete(int id);
    }
}
