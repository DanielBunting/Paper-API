using Paper.Models.ViewModels;

namespace Paper.Services
{
    public class UserService : IUserService
    {
        public Task<bool> RegisterNewAppleUser(string appleSubId, NewUser newUser)
        {
            // This would save the user in the database.
            throw new NotImplementedException();
        }
    }
}
