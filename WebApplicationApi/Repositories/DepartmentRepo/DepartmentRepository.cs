using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.DepartmentRepo
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

        public async Task<DepartmentModel> CreateAsync(DepartmentViewModel departmentViewModel)
        {
            Department department = _mapper.Map<Department>(departmentViewModel);
            department.CreatedBy = 1;
            department.CreatedDate = DateTime.Now;
            var entity = _context.Departments.Add(department);
            await _context.SaveChangesAsync();
            var result = _mapper.Map<DepartmentModel>(entity.Entity);
            return result;
        }

        public async Task<DepartmentModel> UpdateAsync(int id, DepartmentViewModel departmentViewModel)
        {
            var updateDepartment = _context.Departments.Where(d => d.Id == id).FirstOrDefault();
            if (updateDepartment != null)
            {
                updateDepartment.UpdatedDate = DateTime.Now;
                updateDepartment.UpdatedBy = 1;

                updateDepartment.Name = departmentViewModel.Name;
                updateDepartment.LevelDepartment = departmentViewModel.LevelDepartment;
                updateDepartment.ParentId = departmentViewModel.ParentId;
                updateDepartment.IsActive = departmentViewModel.IsActive;

                _context.Departments.Update(updateDepartment);
                await _context.SaveChangesAsync();
            }
            var result = _mapper.Map<DepartmentModel>(updateDepartment);
            return result;
        }

        public async Task DeleteAsync(int id)
        {
            var deleteDepartment = _context.Departments.SingleOrDefault(d => d.Id == id);
            //if (deleteDepartment != null)
            //{
            //    _context.Departments.Remove(deleteDepartment);
            //    await _context.SaveChangesAsync();
            //}
            _context.Departments.Remove(deleteDepartment);
            await _context.SaveChangesAsync();
        }
    }
}
