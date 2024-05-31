using SoUs.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoUs.DataAccess
{
    public class EmployeeRepository(SoUsDbContext sosuContext) : Repository<Employee>(sosuContext), IEmployeeRepository
    {
        public IEnumerable<Employee> GetEmployeesIn(Assignment assignment)
        {
            return p_sosuContext.Employees.Where(e => e.Assignments.Contains(assignment)).ToList();
        }
    }
}
