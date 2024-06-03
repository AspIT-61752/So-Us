namespace SoUs.Entity
{
    public class CareCenter
    {
        #region Fields

        private int careCenterId;
        private string name;
        private Address address;
        private ICollection<Resident> residents;

        #endregion

        #region Constructors

        public CareCenter(int careCenterId, string name, Address address, List<Resident> residents)
        {
            CareCenterId = careCenterId;
            Name = name;
            Address = address;
            Residents = residents;
        }

        // Parameterless constructor for EF Core
        public CareCenter() { }

        #endregion

        #region Properties

        //[Key]
        public int CareCenterId { get => careCenterId; set => careCenterId = value; }

        //[Required]
        //[StringLength(256)]
        public string Name { get => name; set => name = value; }

        //[Required]
        public Address Address { get => address; set => address = value; }

        public ICollection<Resident> Residents { get => residents; set => residents = value; }

        #endregion

        #region Methods
        #endregion
    }
}
