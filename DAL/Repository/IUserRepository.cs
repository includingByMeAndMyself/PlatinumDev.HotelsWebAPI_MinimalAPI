using PlatinumDev.HotelsWebAPI.Auth;

namespace PlatinumDev.HotelsWebAPI.DAL.Repository
{
    public interface IUserRepository
    {
        UserDto GetUser(UserModel userModel);
    }
}
