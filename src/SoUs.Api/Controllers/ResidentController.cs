using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entity;

namespace SoUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController(IResident repo) : Controller
    {
        private readonly IResident repo = repo;

        [HttpPost]
        public void AddNewResident([FromQuery] Resident resident)
        {
            repo.Add(resident);
        }

        [HttpPost]
        [Route(nameof(AddResidents))]
        public void AddResidents([FromQuery] List<Resident> residents)
        {
            foreach (var resident in residents)
            {
                repo.Add(resident);
            }
        }

        [HttpDelete]
        [Route(nameof(DeleteResident))]
        public void DeleteResident([FromQuery] Resident resident)
        {
            repo.Delete(resident);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Resident> GetResidentBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Resident> GetAll()
        {
            return repo.GetAll();
        }

        [HttpGet]
        [Route("GetByRoomNumber")]
        public IEnumerable<Resident> GetResidentsBy([FromQuery] string roomNumber)
        {
            return repo.GetResidentsBy(roomNumber);

        }

        [HttpPut]
        public void UpdateResident([FromQuery] Resident resident)
        {
            repo.Update(resident);
        }
    }
}
