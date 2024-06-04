using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entity;

namespace SoUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressController(IRepository<Address> repo) : Controller
    {
        private readonly IRepository<Address> repo = repo;

        [HttpPost]
        public void AddNewAddress([FromQuery] Address address)
        {
            repo.Add(address);
        }

        [HttpDelete]
        [Route(nameof(DeleteAddress))]
        public void DeleteAddress([FromQuery] Address address)
        {
            repo.Delete(address);
        }

        [HttpDelete]
        [Route(nameof(DeleteAddressBy))]
        public void DeleteAddressBy([FromQuery] int id)
        {
            repo.DeleteBy(id);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Address> GetAddressBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Address> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPut]
        public void UpdateAddressBy([FromQuery] Address address)
        {
            repo.Update(address);
        }
    }
}
