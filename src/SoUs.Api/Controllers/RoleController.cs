using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entity;

namespace SoUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(IRoleRepository repo) : Controller
    {
        private readonly IRoleRepository repo = repo;

        [HttpPost]
        public void AddNewRole([FromQuery] Role role)
        {
            repo.Add(role);
        }

        [HttpDelete]
        [Route(nameof(DeleteRole))]
        public void DeleteRole([FromQuery] Role role)
        {
            repo.Delete(role);
        }

        [HttpDelete]
        [Route(nameof(DeleteRoleBy))]
        public void DeleteRoleBy([FromQuery] int id)
        {
            repo.DeleteBy(id);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Role> GetRoleBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route("GetByName")]
        public ActionResult<Role> GetRoleBy([FromQuery] string name)
        {
            return repo.GetBy(name);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Role> GetAll()
        {
            return repo.GetAll();
        }

        [HttpPut]
        public void UpdateRoleBy([FromQuery] Role role)
        {
            repo.Update(role);
        }
    }
}
