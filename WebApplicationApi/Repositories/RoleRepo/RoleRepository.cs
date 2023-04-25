using Microsoft.AspNetCore.Identity;

namespace WebApplicationApi.Repositories.RoleRepo
{
    public class RoleRepository : IRoleRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        public RoleRepository(RoleManager<IdentityRole> roleManager)
        {
            _roleManager = roleManager;
        }
        public async Task<IdentityResult> CreateAsync(string roleName)
        {
            IdentityRole role = new IdentityRole(roleName);
            var result = await _roleManager.CreateAsync(role);
            return result;
        }

        public async Task DeleteAsync(string roleId)
        {
            IdentityRole role = await _roleManager.FindByIdAsync(roleId);
            await _roleManager.DeleteAsync(role);
        }
    }
}
