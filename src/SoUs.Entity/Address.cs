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

        public Address() { } // Parameterless constructor for EF Core

        #endregion

        #region Properties

        // Fluent API. Don't pollute the 
        // Ask AI how to get this "From Data annotations to fluent API".

        //[Key]
        public int AddressId { get => addressId; set => addressId = value; }

        //[Required]
        //[StringLength(256)]
        public string Street { get => street; set => street = value; }

        // The full name of Bangkok is 187 characters long
        //[Required]
        //[StringLength(256)]
        public string City { get => city; set => city = value; }

        //[Required]
        //[StringLength(128)]
        public string State { get => state; set => state = value; }

        //[Required]
        //[StringLength(32)]
        public int Zip { get => zip; set => zip = value; }

        #endregion

        #region Methods
        #endregion

    }
}
