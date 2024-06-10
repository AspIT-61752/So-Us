using Microsoft.AspNetCore.Mvc;
using SoUs.DataAccess;
using SoUs.Entity;

namespace SoUs.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssignmentController(IAssignmentRepository repo) : Controller
    {
        private readonly IAssignmentRepository repo = repo;

        [HttpPost]
        public void AddNewAssignment([FromQuery] Assignment assignment)
        {
            repo.Add(assignment);
        }

        [HttpDelete]
        [Route(nameof(DeleteAssignment))]
        public void DeleteAssignment([FromQuery] Assignment assignment)
        {
            repo.Delete(assignment);
        }

        [HttpDelete]
        [Route(nameof(DeleteAssignmentBy))]
        public void DeleteAssignmentBy([FromQuery] int id)
        {
            repo.DeleteBy(id);
        }

        [HttpGet]
        [Route("GetByDate")]
        public IEnumerable<Assignment> GetAssignmentOn([FromQuery] Employee employee, [FromQuery] DateTime date)
        {
            return repo.GetAssignmentsOn(employee, date);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Assignment> GetAssignmentBy([FromQuery] int id)
        {
            return repo.GetBy(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Assignment> GetAll()
        {
            return repo.GetAll();
        }

        [HttpGet]
        [Route("GetAssignmentsFor")]
        public IEnumerable<Assignment> GetAssignmentsFor([FromQuery] Employee employee)
        {
            return repo.GetAssignmentsFor(employee);
        }

        [HttpPut]
        public void UpdateAssignmentBy([FromQuery] Assignment assignment)
        {
            repo.Update(assignment);
        }
    }
}
