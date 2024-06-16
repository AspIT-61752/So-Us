using Microsoft.EntityFrameworkCore;
using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class AssignmentRepository(SoUsDbContext sosuContext) : Repository<Assignment>(sosuContext), IAssignmentRepository
    {
        public void AddEmployeeToTask(int assignmentId, int employeeId)
        {
            Assignment assignment = p_sosuContext.Assignments
                .FirstOrDefault(a => a.AssignmentId == assignmentId);

            Employee employee = p_sosuContext.Employees.FirstOrDefault(e => e.EmployeeId == employeeId);

            assignment.Employees.Add(employee);

            p_sosuContext.SaveChanges();
        }

        public IEnumerable<Assignment> GetAssignmentsFor(Employee employee)
        {
            List<Assignment> assignments = p_sosuContext.Assignments
                .Where(a => a.Employees.Contains(employee))
                .Include(a => a.Resident)
                .Include(a => a.Employees)
                .ToList();

            return assignments;
        }

        public IEnumerable<Assignment> GetAssignmentsOn(Employee employee, DateTime date)
        {
            List<Assignment> assignments = p_sosuContext.Assignments
                .Where(a => a.Employees.Any(e => e.EmployeeId == employee.EmployeeId) && a.TimeStart.Date.Date == date.Date)
                .Include(a => a.Resident)
                .Include(a => a.Employees)
                .ToList();
            //List<Assignment> assignments = p_sosuContext.Assignments
            //    .Where(a => a.TimeStart.Date == date.Date && a.Employees.Contains(employee))
            //    .Include(a => a.Resident)
            //    .Include(a => a.Employees)
            //    .ToList();

            return assignments;
        }

        public override Assignment GetBy(int id)
        {
            Assignment assignment = p_sosuContext.Assignments
                .Include(a => a.Employees)
                .Include(a => a.Resident)
                .Include(a => a.Medicine)
                .FirstOrDefault(a => a.AssignmentId == id);
            return p_sosuContext.Assignments
                .Include(a => a.Employees)
                .Include(a => a.Resident)
                .FirstOrDefault(a => a.AssignmentId == id);
        }
    }
}
