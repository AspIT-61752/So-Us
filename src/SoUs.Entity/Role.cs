using System.ComponentModel.DataAnnotations;

namespace SoUs.Entity
{
    public class Role
    {
        #region Fields

        private int roleId;
        private string roleName;



        #endregion

        #region Constructors

        public Role(int roleId, string roleName)
        {
            RoleId = roleId;
            RoleName = roleName;
        }

        #endregion

        #region Properties

        [Key]
        public int RoleId { get => roleId; set => roleId = value; }

        [Required]
        public string RoleName { get => roleName; set => roleName = value; }

        #endregion

        #region Methods
        #endregion
    }
}
