namespace SoUs.Entity
{
    public class Assignment
    {
        #region Fields

        private int assignmentId;
        private string name;
        private DateTime timeStart;
        private DateTime timeEnd;
        private Resident resident;
        private Employee employee;
        private Medicine medicine;

        #endregion

        #region Constructors

        public Assignment(int assignmentId, string name, DateTime timeStart, DateTime timeEnd, Resident resident, Employee employee, Medicine medicine)
        {
            AssignmentId = assignmentId;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employee = employee;
            Medicine = medicine;
        }

        #endregion

        #region Properties

        public int AssignmentId { get => assignmentId; set => assignmentId = value; }
        public string Name { get => name; set => name = value; }
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }
        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }
        public Resident Resident { get => resident; set => resident = value; }
        public Employee Employee { get => employee; set => employee = value; }
        public Medicine Medicine { get => medicine; set => medicine = value; }

        #endregion

        #region Methods
        #endregion
    }
}