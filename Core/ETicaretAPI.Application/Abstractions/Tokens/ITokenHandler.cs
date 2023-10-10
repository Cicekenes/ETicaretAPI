using ETicaretAPI.Application.DTOs;
using ETicaretAPI.Domain.Entities.Identity;

namespace ETicaretAPI.Application.Abstractions.Tokens
{
    public interface ITokenHandler
    {
        /// <summary>
        /// Jwt token'in diğer adı Access tokendir.
        /// </summary>
        Token CreateAccessToken(int second,AppUser user);
        string CreateRefreshToken();
    }
}
