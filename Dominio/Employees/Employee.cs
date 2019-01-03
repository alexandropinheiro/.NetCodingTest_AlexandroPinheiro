using Domain.Base;

namespace Domain.Employees
{
    public class Employee : EntidadeBase
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Department { get; set; }
    }
}
