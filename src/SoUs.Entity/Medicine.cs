namespace SoUs.Entity
{
    public class Medicine
    {
        #region Fields

        private int medicineId;
        private string name;
        private int dosage;
        private string unit;
        private bool administered;

        #endregion

        #region Constructors

        public Medicine(int medicineId, string name, int dosage, string unit, bool administered)
        {
            MedicineId = medicineId;
            Name = name;
            Dosage = dosage;
            Unit = unit;
            Administered = administered;
        }

        #endregion

        #region Properties

        //[Key]
        public int MedicineId { get => medicineId; set => medicineId = value; }

        //[Required]
        //[StringLength(64)]
        public string Name { get => name; set => name = value; }

        //[Required]
        public int Dosage { get => dosage; set => dosage = value; }

        //[Required]
        //[StringLength(8)]
        public string Unit { get => unit; set => unit = value; }

        //[Required]
        public bool Administered { get => administered; set => administered = value; }

        #endregion

        #region Methods
        #endregion
    }
}