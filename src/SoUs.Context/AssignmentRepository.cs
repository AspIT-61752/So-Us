using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class AssignmentRepository(SoUsDbContext sosuContext) : Repository<Assignment>(sosuContext), IAssignmentRepository
    {
        public IEnumerable<Assignment> GetAssignmentsFor(Employee employee)
        {
            return p_sosuContext.Assignments.Where(a => a.Employee.Contains(employee)).ToList();
        }

        public IEnumerable<Assignment> GetAssignmentsOn(DateTime date)
        {
            return p_sosuContext.Assignments.Where(a => a.TimeStart.Date == date.Date).ToList();
        }
    }
}
