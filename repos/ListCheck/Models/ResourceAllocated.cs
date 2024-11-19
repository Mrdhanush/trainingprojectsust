using System.ComponentModel.DataAnnotations;

namespace AllocateResourceAPI.Models
{
    public partial class ResourceAllocated
    {
        [Key]  // Mark this property as the primary key
        public int AllocationId { get; set; }

        public int IncidentId { get; set; }
        public string IncidentType { get; set; }
        public string Severity { get; set; }
        public string Location { get; set; }
        public int QuantityAllocated { get; set; }
        public List<string> ResourceNames { get; set; }
    }
}
