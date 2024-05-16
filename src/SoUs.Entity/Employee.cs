namespace SoUs.Entity
{
    public class Employee
    {
        #region Fields

        private int employeeId;
        private List<Assignment> assignments;
        private List<Role> role;
        private string name;
        private CareCenter careCenter;

        #endregion

        #region Constructors

        public Employee(int employeeId, List<Assignment> assignments, List<Role> role, string name, CareCenter careCenter)
        {
            EmployeeId = employeeId;
            Assignments = assignments;
            Role = role;
            Name = name;
            CareCenter = careCenter;
        }

        #endregion

        #region Properties

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public List<Assignment> Assignments { get => assignments; set => assignments = value; }
        public List<Role> Role { get => role; set => role = value; }
        public string Name { get => name; set => name = value; }
        public CareCenter CareCenter { get => careCenter; set => careCenter = value; }

        #endregion

        #region Methods
        #endregion
    }
}
