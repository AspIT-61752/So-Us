﻿namespace SoUs.Entity
{
    public class Prescription
    {
        #region Fields

        private int prescriptionId;
        private string name;
        private int dosage;
        private string unit;

        #endregion

        #region Constructors

        public Prescription(int prescriptionId, string name, int dosage, string unit)
        {
            PrescriptionId = prescriptionId;
            Name = name;
            Dosage = dosage;
            Unit = unit;
        }

        #endregion

        #region Properties

        //[Key]
        public int PrescriptionId { get => prescriptionId; set => prescriptionId = value; }

        //[Required]
        //[StringLength(64)]
        public string Name { get => name; set => name = value; }

        //[Required]
        public int Dosage { get => dosage; set => dosage = value; }

        //[Required]
        //[StringLength(8)]
        public string Unit { get => unit; set => unit = value; }

        #endregion

        #region Methods
        #endregion
    }
}