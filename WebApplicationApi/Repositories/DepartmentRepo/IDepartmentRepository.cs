using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.DepartmentRepo
{
    public interface IDepartmentRepository
    {
        Task<List<DepartmentModel>> GetDepartmentsByConditionAsync();
        Task<DepartmentModel> GetDepartmentAsync(int id);
        Task<DepartmentModel> CreateAsync(DepartmentViewModel departmentViewModel);
        Task<DepartmentModel> UpdateAsync(int id, DepartmentViewModel departmentViewModel);
        Task DeleteAsync(int id);
    }
}
