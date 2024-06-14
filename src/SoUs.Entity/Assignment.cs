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
        private List<Employee> employees;
        private List<Medicine> medicine;
        private bool isComplete;

        #endregion

        #region Constructors

        public Assignment()
        {
            Employees = new List<Employee>();
            Medicine = new List<Medicine>();
        }

        public Assignment(int assignmentId, string name, DateTime timeStart, DateTime timeEnd, Resident resident, List<Employee> employee, List<Medicine> medicine, bool isComplete)
        {
            AssignmentId = assignmentId;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employees = employee ?? new List<Employee>();
            Medicine = medicine ?? new List<Medicine>();
            IsComplete = isComplete;
        }

        #endregion

        #region Properties

        public int AssignmentId { get => assignmentId; set => assignmentId = value; }

        public string Name { get => name; set => name = value; }

        public DateTime TimeStart { get => timeStart; set => timeStart = value; }

        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }

        public Resident Resident { get => resident; set => resident = value; }

        public List<Employee> Employees { get => employees; set => employees = value; }

        public List<Medicine> Medicine { get => medicine; set => medicine = value; }

        public bool IsComplete { get => isComplete; set => isComplete = value; }

        #endregion

        #region Methods
        #endregion
    }
}