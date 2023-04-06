using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.Department
{
    public interface IDepartmentRepository
    {
        public Task<List<DepartmentModel>> GetDepartmentsByConditionAsync();
        public Task<DepartmentModel> GetDepartmentAsync(int id);
    }
}
