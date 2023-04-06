using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.DimensionRepo
{
    public interface IDimensionRepository
    {
        Task<DimensionlListModel> GetAllAsync(int? pageSize, int? pageIndex, string? name);
        Task<DimensionModel> CreateAsync(DimensionViewModel dimensionViewModel);
        Task<DimensionModel> UpdateAsync(int id, DimensionViewModel dimensionViewModel);
        Task DeleteAsync(int id);
    }
}
