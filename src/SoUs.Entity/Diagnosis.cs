using System.ComponentModel.DataAnnotations;

namespace SoUs.Entity
{
    public class Diagnosis
    {
        #region Fields

        private int diagnosisId;
        private string name;
        private string description;

        #endregion

        #region Constructors

        public Diagnosis(int diagnosisId, string name, string description)
        {
            DiagnosisId = diagnosisId;
            Name = name;
            Description = description;
        }
        #endregion

        #region Properties

        [Key]
        public int DiagnosisId { get => diagnosisId; set => diagnosisId = value; }

        [Required]
        public string Name { get => name; set => name = value; }

        public string Description { get => description; set => description = value; }

        #endregion

        #region Methods
        #endregion
    }
}