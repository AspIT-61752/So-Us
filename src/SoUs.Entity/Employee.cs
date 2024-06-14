namespace SoUs.Entity
{
    public class Employee
    {
        #region Fields

        private int employeeId;
        private ICollection<Assignment> assignments;
        private ICollection<Role> role;
        private string name;
        private CareCenter careCenter;

        #endregion

        #region Constructors
        public Employee()
        {
            Assignments = new List<Assignment>();
            Role = new List<Role>();
        }

        public Employee(int employeeId, List<Assignment> assignments, List<Role> role, string name, CareCenter careCenter)
        {
            EmployeeId = employeeId;
            Assignments = assignments ?? new List<Assignment>();
            Role = role ?? new List<Role>();
            Name = name;
            CareCenter = careCenter;
        }

        #endregion

        #region Properties

        //[Key]
        public int EmployeeId { get => employeeId; set => employeeId = value; }


        public ICollection<Assignment> Assignments { get => assignments; set => assignments = value; }

        //[Required]
        public ICollection<Role>? Role { get => role; set => role = value; }

        //[Required]
        //[StringLength(128)]
        public string Name { get => name; set => name = value; }

        //[Required]
        public CareCenter CareCenter { get => careCenter; set => careCenter = value; }

        #endregion

        #region Methods
        #endregion
    }
}
