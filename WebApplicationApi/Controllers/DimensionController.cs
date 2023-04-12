using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using WebApplicationApi.Models;
using WebApplicationApi.Repositories.DimensionRepo;

namespace WebApplicationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DimensionController : ControllerBase
    {
        private readonly IDimensionRepository _dimensionRepository;
        public DimensionController(IDimensionRepository dimensionRepository)
        {
            _dimensionRepository = dimensionRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync(int? pageSize, int? pageIndex, string? name)
        {
            try
            {
                return Ok(await _dimensionRepository.GetAllAsync(pageSize, pageIndex, name));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPost]
        public async Task<IActionResult> Create(DimensionViewModel LinhVuc)
        {
            try
            {
                return Ok(await _dimensionRepository.CreateAsync(LinhVuc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpPut]
        public async Task<IActionResult> Update(int id, DimensionViewModel LinhVuc)
        {
            try
            {
                return Ok(await _dimensionRepository.UpdateAsync(id, LinhVuc));
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _dimensionRepository.DeleteAsync(id);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
