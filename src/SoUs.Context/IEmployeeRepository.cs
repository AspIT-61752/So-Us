using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesIn(Assignment assignment);
    }
}
