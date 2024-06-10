using SoUs.Entity;

namespace SoUs.DataAccess
{
    public class ResidentRepository(SoUsDbContext sousContext) : Repository<Resident>(sousContext), IResident
    {
        public List<Resident> GetResidentsBy(string roomNumber)
        {
            return p_sosuContext.Residents.Where(r => r.RoomNumber == roomNumber)
                .ToList();
        }
    }
}
