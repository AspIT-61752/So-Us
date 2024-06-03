using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        IEnumerable<Employee> GetEmployeesIn(Assignment assignment);
        Employee GetBy(int id);
        IEnumerable<Employee> GetBy(Role role);
    }
}
