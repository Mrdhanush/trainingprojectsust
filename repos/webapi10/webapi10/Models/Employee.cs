namespace webapi10.Models
{
    public class Employee
    {
        public static int Count { get; internal set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public string Department { get; set; }
        
      
    }
}