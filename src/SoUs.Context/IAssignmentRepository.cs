using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Assignment> GetAssignmentsOn(DateTime date);
        IEnumerable<Assignment> GetAssignmentsFor(Employee employee);
    }
}
