using Paper.Models.EndpointModels;

namespace Paper.Services
{
    public class UserService : IUserService
    {
        public Task<bool> RegisterNewUser(string appleSubId, NewUser newUser)
        {

            // This would save the user in the database.
            throw new NotImplementedException();
        }
    }
}
