using Microsoft.AspNetCore.Identity;
using SportTicketingAPI.Models;

namespace SportTicketingAPI.Repositories
{
    public interface IUserRepository
    {
        public Task<IdentityResult> SignUpAsync(SignUpModel signUpModel);
        public Task<string> SignInAsync(SignInModel signInModel);
    }
}
