using ETicaretAPI.Application.DTOs;

namespace ETicaretAPI.Application.Abstractions.Tokens
{
    public interface ITokenHandler
    {
        /// <summary>
        /// Jwt token'in diğer adı Access tokendir.
        /// </summary>
        Token CreateAccessToken(int minute);
    }
}
