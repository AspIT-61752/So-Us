using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IRoleRepository : IRepository<Role>
    {
        Role GetBy(string name);
        Role GetBy(int id);
    }
}
