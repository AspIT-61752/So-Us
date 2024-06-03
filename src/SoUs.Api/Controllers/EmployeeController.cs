using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entity;

namespace SoUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeRepository repo) : Controller
    {
        private readonly IEmployeeRepository repo = repo;

        [HttpPost]
        public void AddNewEmployee([FromQuery] Employee employee)
        {
            repo.Add(employee);
        }

        [HttpDelete]
        [Route(nameof(DeleteEmployee))]
        public void DeleteEmployee([FromQuery] Employee employee)
        {
            repo.Delete(employee);
        }

        [HttpDelete]
        [Route(nameof(DeleteEmployeeBy))]
        public void DeleteEmployeeBy([FromQuery] int id)
        {
            repo.DeleteBy(id);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Employee> GetEmployeeBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Employee> GetAll()
        {
            return repo.GetAll();
        }

        [HttpGet]
        [Route("GetAllByRole")]
        public IEnumerable<Employee> GetAllByRole([FromQuery] Role role)
        {
            return repo.GetBy(role);
        }

        [HttpPut]
        public void UpdateEmployeeBy([FromQuery] Employee employee)
        {
            repo.Update(employee);
        }
    }
}
