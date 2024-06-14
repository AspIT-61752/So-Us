using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IAssignmentRepository : IRepository<Assignment>
    {
        IEnumerable<Assignment> GetAssignmentsOn(Employee employee, DateTime date);
        IEnumerable<Assignment> GetAssignmentsFor(Employee employee);
        //Assignment GetAssignmentById(int id);
        void AddEmployeeToTask(int assignmentId, int employeeId);

    }
}
