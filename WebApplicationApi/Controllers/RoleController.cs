using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Repositories.AccountRepo;
using WebApplicationApi.Repositories.RoleRepo;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        public IRoleRepository roleRepository;
        public RoleController(IRoleRepository repo)
        {
            roleRepository = repo;
        }
        [HttpPost]
        public async Task<IActionResult> Create(string nameRole)
        {
            return Ok(await roleRepository.CreateAsync(nameRole));
        }
    }
}
