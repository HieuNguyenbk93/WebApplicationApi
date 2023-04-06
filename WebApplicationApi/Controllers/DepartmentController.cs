using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Repositories.Department;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetDepartmentsByCondition()
        {
            try
            {
                return Ok(await _departmentRepository.GetDepartmentsByConditionAsync());
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
