
using Ham30.Server.Services.Common;
using Ham30.Server.Services.Identity.Requests;
using Ham30.Sheard.Wrapper;
using System.Threading.Tasks;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface IAccountService : IService
    {
        Task<Sheard.Wrapper.IResult> UpdateProfileAsync(UpdateProfileRequest model, string userId);

        Task<Sheard.Wrapper.IResult> ChangePasswordAsync(ChangePasswordRequest model, string userId);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}