using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using WebApplicationApi.Data;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.ClaimRepository
{
    public class ClaimRepository : IClaimRepository
    {
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly MyDbContext _myDb;
        public ClaimRepository(RoleManager<IdentityRole> roleManager, MyDbContext myDb)
        {
            _roleManager = roleManager;
            _myDb = myDb;
        }

        public Task<IdentityResult> CreateRoleClaimAsync(string roleId, string claimName)
        {
            var role = _roleManager.Roles.FirstOrDefault(x => x.Id == roleId);

            throw new NotImplementedException();
        }
    }
}
