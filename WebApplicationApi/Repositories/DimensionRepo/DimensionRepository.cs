using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.DimensionRepo
{
    public class DimensionRepository : IDimensionRepository
    {
        private readonly IMapper _mapper;
        private readonly MyDbContext _context;
        public DimensionRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public async Task<DimensionModel> CreateAsync(DimensionViewModel dimensionViewModel)
        {
            Dimension dimension = _mapper.Map<Dimension>(dimensionViewModel);
            dimension.CreatedBy = 1;
            dimension.CreatedDate = DateTime.Now;
            var entity  = await _context.Dimensions.AddAsync(dimension);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<DimensionModel>(entity.Entity);
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteDimension = _context.Dimensions.SingleOrDefault(d => d.Id == id);
            if (deleteDimension != null)
            {
                _context.Dimensions.Remove(deleteDimension);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<DimensionlListModel> GetAllAsync(int? pageSize, int? pageIndex, string? name)
        {
            var dimensions = await _context.Dimensions.Where(d => string.IsNullOrEmpty(name) || d.Name.ToLower().Contains(name)
                ).OrderByDescending(d => d.Id).ToListAsync();
            int totalRecords = dimensions.Count;
            
            DimensionlListModel result = new DimensionlListModel();
            result.TotalRecords = totalRecords;

            if (pageSize.HasValue && pageIndex.HasValue && totalRecords > 0)
            {
                result.Dimensions = _mapper.Map<List<DimensionModel>>(dimensions.Skip((pageIndex.Value - 1) * pageSize.Value).Take(pageSize.Value));
                return result;
            }
            else
            {
                result.Dimensions = _mapper.Map<List<DimensionModel>>(dimensions);
                return result;
            }
        }

        public async Task<DimensionModel> UpdateAsync(int id, DimensionViewModel dimensionViewModel)
        {
            var updateDimension = _context.Dimensions.Where(d => d.Id == id).FirstOrDefault();
            if (updateDimension != null)
            {
                updateDimension.UpdatedDate = DateTime.Now;
                updateDimension.UpdatedBy = 1;
                updateDimension.Name = dimensionViewModel.Name;
                _context.Dimensions.Update(updateDimension);
                await _context.SaveChangesAsync();
            }
            var result = _mapper.Map<DimensionModel>(updateDimension);
            return result;
        }
    }
}
