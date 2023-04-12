using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Data.SqlTypes;
using WebApplicationApi.Models;
using WebApplicationApi.Repositories.DepartmentRepo;

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
        [HttpPost]
        public async Task<DepartmentModel> Create(DepartmentViewModel model)
        {
            return await _departmentRepository.CreateAsync(model);
        }
        [HttpPut]
        public async Task<DepartmentModel> Update(int id,DepartmentViewModel model)
        {
            return await _departmentRepository.UpdateAsync(id, model);
        }
        [HttpDelete]
        public async Task<bool> Delete(int id)
        {
            await _departmentRepository.DeleteAsync(id);
            return true;
        }
    }
}
