using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationApi.Repositories.ClaimRepository;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaimController : ControllerBase
    {
        private readonly IClaimRepository _claimRepository;
        public ClaimController(IClaimRepository claimRepository)
        {
            _claimRepository = claimRepository;
        }
        [HttpGet]
        public async Task GetAll(string userId)
        {
            await _claimRepository.GetAllAsync(userId);
        }
    }
}
