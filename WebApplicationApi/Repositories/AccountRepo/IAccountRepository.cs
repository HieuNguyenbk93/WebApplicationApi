using Microsoft.AspNetCore.Identity;
using WebApplicationApi.Models;

namespace WebApplicationApi.Repositories.AccountRepo
{
    public interface IAccountRepository
    {
        Task<IdentityResult> SignUpAsync(SignUpModel model);
        Task<string> SignInAsync(SignInModel model);
    }
}
