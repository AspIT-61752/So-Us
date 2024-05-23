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
        private List<Employee> employee;
        private List<Medicine> medicine;
        private bool isComplete;

        #endregion

        #region Constructors

        public Assignment(int assignmentId, string name, DateTime timeStart, DateTime timeEnd, Resident resident, List<Employee> employee, List<Medicine> medicine, bool isComplete)
        {
            AssignmentId = assignmentId;
            Name = name;
            TimeStart = timeStart;
            TimeEnd = timeEnd;
            Resident = resident;
            Employee = employee;
            Medicine = medicine;
            IsComplete = isComplete;
        }

        public Assignment() { }

        #endregion

        #region Properties

        //[Key]
        public int AssignmentId { get => assignmentId; set => assignmentId = value; }

        //[Required]
        //[StringLength(32)]
        public string Name { get => name; set => name = value; }

        //[Required]
        public DateTime TimeStart { get => timeStart; set => timeStart = value; }

        //[Required]
        public DateTime TimeEnd { get => timeEnd; set => timeEnd = value; }

        public Resident Resident { get => resident; set => resident = value; }

        public List<Employee> Employee { get => employee; set => employee = value; }

        public List<Medicine> Medicine { get => medicine; set => medicine = value; }

        public bool IsComplete { get => isComplete; set => isComplete = value; }

        #endregion

        #region Methods
        #endregion
    }
}