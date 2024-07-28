using PrimeiraApi.Model;

namespace PrimeiraApi.Infraestrutura
{
    public class EmployeeRepository
    {

        private readonly ConnectionContext _context = new ConnectionContext();
        public void Add(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }
        public List<Employee> GetEmployees()
        {
            return _context.Employees.ToList();

        }
    }
}
