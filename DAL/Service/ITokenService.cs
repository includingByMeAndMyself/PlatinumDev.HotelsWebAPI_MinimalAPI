using PlatinumDev.HotelsWebAPI.Auth;

namespace PlatinumDev.HotelsWebAPI.DAL.Service
{
    public interface ITokenService
    {
        string BuildToken(string key, string issuer, UserDto user);
    }
}
