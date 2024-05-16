using System.ComponentModel.DataAnnotations;

namespace SoUs.Entity
{
    public class Resident
    {
        #region Fields

        private int residentId;
        private string name;
        private string roomNumber;
        private ICollection<Diagnosis> diagnosis;
        private ICollection<Prescription> prescriptions;
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

        public Resident() { }

        #endregion

        #region Properties

        [Key]
        public int ResidentId { get => residentId; set => residentId = value; }

        [Required]
        [StringLength(128)]
        public string Name { get => name; set => name = value; }

        [Required]
        [StringLength(16)]
        public string RoomNumber { get => roomNumber; set => roomNumber = value; }
        public ICollection<Diagnosis> Diagnosis { get => diagnosis; set => diagnosis = value; }
        public ICollection<Prescription> Prescriptions { get => prescriptions; set => prescriptions = value; }
        public string Notes { get => notes; set => notes = value; }

        #endregion

        #region Methods
        #endregion
    }
}