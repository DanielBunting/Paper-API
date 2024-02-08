using Paper.Models.ViewModels;

namespace Paper.Services
{
    public interface IUserService
    {
        public Task<bool> RegisterNewAppleUser(string appleSubId, NewUser newUser);
    }
}
