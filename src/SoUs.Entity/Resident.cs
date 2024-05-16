namespace SoUs.Entity
{
    public class Resident
    {
        #region Fields

        private int residentId;
        private string name;
        private string roomNumber;
        private List<Diagnosis> diagnosis;
        private List<Prescription> prescriptions;
        private string notes;

        #endregion

        #region Constructors

        public Resident(int residentId, string name, string roomNumber, List<Diagnosis> diagnosis, List<Prescription> prescriptions, string notes)
        {
            ResidentId = residentId;
            Name = name;
            RoomNumber = roomNumber;
            Diagnosis = diagnosis;
            Prescriptions = prescriptions;
            Notes = notes;
        }

        #endregion

        #region Properties

        public int ResidentId { get => residentId; set => residentId = value; }
        public string Name { get => name; set => name = value; }
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public List<Diagnosis> Diagnosis { get => diagnosis; set => diagnosis = value; }
        public List<Prescription> Prescriptions { get => prescriptions; set => prescriptions = value; }
        public string Notes { get => notes; set => notes = value; }

        #endregion

        #region Methods
        #endregion
    }
}