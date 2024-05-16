namespace SoUs.Entity
{
    public class Address
    {
        #region Fields

        private int addressId;
        private string street;
        private string city;
        private string state;
        private int zip;

        #endregion

        #region Constructors

        public Address(int addressId, string street, string city, string state, int zip)
        {
            AddressId = addressId;
            Street = street;
            City = city;
            State = state;
            Zip = zip;
        }

        #endregion

        #region Properties

        public int AddressId { get => addressId; set => addressId = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zip { get => zip; set => zip = value; }

        #endregion

        #region Methods
        #endregion

    }
}
