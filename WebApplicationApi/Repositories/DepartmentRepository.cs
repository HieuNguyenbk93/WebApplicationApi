using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly IMapper _mapper;
        private readonly MyDbContext _context;
        public DepartmentRepository(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DepartmentModel>> GetDepartmentsByConditionAsync()
        {
            var departments = await _context.Departments.ToListAsync();
            return _mapper.Map<List<DepartmentModel>>(departments);
        }
        public async Task<DepartmentModel> GetDepartmentAsync(int id)
        {
            var deparment = await _context.Departments.FindAsync(id);
            return _mapper.Map<DepartmentModel>(deparment);
        }
    }
}
