using System.ComponentModel.DataAnnotations;

namespace SoUs.Entity
{
    public class CareCenter
    {
        #region Fields

        private int employeeId;
        private string name;
        private string address;
        private ICollection<Resident> residents;

        #endregion

        #region Constructors

        public CareCenter(int employeeId, string name, string address, List<Resident> residents)
        {
            EmployeeId = employeeId;
            Name = name;
            Address = address;
            Residents = residents;
        }

        // Parameterless constructor for EF Core
        public CareCenter() { }

        #endregion

        #region Properties

        [Key]
        public int EmployeeId { get => employeeId; set => employeeId = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        [Required]
        public string Address { get => address; set => address = value; }

        public ICollection<Resident> Residents { get => residents; set => residents = value; }

        #endregion

        #region Methods
        #endregion
    }
}
