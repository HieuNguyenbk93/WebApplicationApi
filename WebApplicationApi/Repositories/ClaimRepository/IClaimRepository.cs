using Microsoft.AspNetCore.Identity;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.ClaimRepository
{
    public interface IClaimRepository
    {
        Task<IdentityResult> CreateRoleClaimAsync(string roleId, string claimName);
    }
}
