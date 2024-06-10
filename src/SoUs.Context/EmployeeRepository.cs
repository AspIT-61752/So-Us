using Microsoft.EntityFrameworkCore;
using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class EmployeeRepository(SoUsDbContext sosuContext) : Repository<Employee>(sosuContext), IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeesIn(Assignment assignment)
        {
            return p_sosuContext.Employees.Where(e => e.Assignments.Contains(assignment))
                .ToList();
        }

        public Employee GetBy(int id)
        {
            // TODO: Fix this. I probaly have to remake the DB for Employees.
            return p_sosuContext.Employees.FirstOrDefault(e => e.EmployeeId == id);
        }

        public IEnumerable<Employee> GetBy(Role role)
        {
            return p_sosuContext.Employees.Where(e => e.Role.Contains(role))
                .Include(e => e.Role)
                .Include(e => e.CareCenter)
                .ToList();
        }

        public IEnumerable<Employee> GetAll()
        {
            return p_sosuContext.Employees
                // This doesn't work because my DB doesn't have a Role column or a CareCenter column. I will fix this later.
                //.Include(e => e.Role)
                //.Include(e => e.CareCenter)
                .ToList();
        }
    }
}
