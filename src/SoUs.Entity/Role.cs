namespace SoUs.Entity
{
    public class Role
    {
        #region Fields

        private int roleId;
        private string roleName;
        private List<Employee> employees;


        #endregion

        #region Constructors

        public Role() { }

        public Role(int roleId, string roleName, List<Employee> employees)
        {
            RoleId = roleId;
            RoleName = roleName;
            this.employees = employees;
        }

        #endregion

        #region Properties

        //[Key]
        public int RoleId { get => roleId; set => roleId = value; }

        //[Required]
        //[StringLength(32)]
        public string RoleName { get => roleName; set => roleName = value; }
        public List<Employee>? Employees { get => employees; set => employees = value; }

        #endregion

        #region Methods
        #endregion
    }
}
