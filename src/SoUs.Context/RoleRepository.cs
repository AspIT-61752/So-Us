using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class RoleRepository(SoUsDbContext sosuContext) : Repository<Role>(sosuContext), IRoleRepository
    {
        public Role GetBy(string name)
        {
            return p_sosuContext.Roles.FirstOrDefault(r => r.RoleName == name);
        }

        public Role GetBy(int id)
        {
            return p_sosuContext.Roles.FirstOrDefault(r => r.RoleId == id);
        }
    }
}
