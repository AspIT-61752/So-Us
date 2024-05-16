namespace SoUs.Entity
{
    public class CareCenter
    {
        #region Fields

        private int employeeId;
        private string name;
        private string address;
        private List<Resident> residents;

        public CareCenter(int employeeId, string name, string address, List<Resident> residents)
        {
            EmployeeId = employeeId;
            Name = name;
            Address = address;
            Residents = residents;
        }

        #endregion

        #region Constructors
        #endregion

        #region Properties

        public int EmployeeId { get => employeeId; set => employeeId = value; }
        public string Name { get => name; set => name = value; }
        public string Address { get => address; set => address = value; }
        public List<Resident> Residents { get => residents; set => residents = value; }

        #endregion

        #region Methods
        #endregion
    }
}
