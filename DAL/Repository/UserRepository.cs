using PlatinumDev.HotelsWebAPI.Auth;

namespace PlatinumDev.HotelsWebAPI.DAL.Repository
{
    public class UserRepository : IUserRepository
    {
        private List<UserDto> _users = new()
        {
            new UserDto("John", "123"),
            new UserDto("Monica", "123"),
            new UserDto("Nike", "123")
        };
        public UserDto GetUser(UserModel userModel) =>
            _users.FirstOrDefault(u =>
                string.Equals(u.UserName, userModel.UserName) &&
                string.Equals(u.Password, userModel.Password)) ??
                throw new Exception();        
    }
}
