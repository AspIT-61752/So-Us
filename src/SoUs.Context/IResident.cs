using SoUs.Entity;

namespace SoUs.DataAccess
{
    public interface IResident : IRepository<Resident>
    {
        List<Resident> GetResidentsBy(string roomNumber);
    }
}
