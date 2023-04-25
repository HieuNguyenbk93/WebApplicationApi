using Microsoft.AspNetCore.Identity;

namespace WebApplicationApi.Repositories.RoleRepo
{
    public interface IRoleRepository
    {
        Task<IdentityResult> CreateAsync(string roleName);
        Task DeleteAsync(string roleId);
    }
}
