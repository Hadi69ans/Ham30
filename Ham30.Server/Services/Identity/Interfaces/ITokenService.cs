using Ham30.Server.Services.Common;
using Ham30.Server.Services.Identity.Requests;
using Ham30.Server.Services.Identity.Response;
using Ham30.Sheard.Wrapper;
using System.Threading.Tasks;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}