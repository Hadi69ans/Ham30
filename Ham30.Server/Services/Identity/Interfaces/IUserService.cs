using Ham30.Server.Services.Common.Interface;
using Ham30.Server.Services.Identity.Requests;
using Ham30.Server.Services.Identity.Response;
using Ham30.Sheard.Wrapper;


namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface IUserService : IService
    {
        Task<Result<List<UserResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<IResult<UserResponse>> GetAsync(string userId);

        Task<Sheard.Wrapper.IResult> RegisterAsync(RegisterRequest request, string origin);

        Task<Sheard.Wrapper.IResult> ToggleUserStatusAsync(ToggleUserStatusRequest request);

        Task<IResult<UserRolesResponse>> GetRolesAsync(string id);

        Task<Sheard.Wrapper.IResult> UpdateRolesAsync(UpdateUserRolesRequest request);

        Task<IResult<string>> ConfirmEmailAsync(string userId, string code);

        Task<Sheard.Wrapper.IResult> ForgotPasswordAsync(ForgotPasswordRequest request, string origin);

        Task<Sheard.Wrapper.IResult> ResetPasswordAsync(ResetPasswordRequest request);

        Task<string> ExportToExcelAsync(string searchString = "");
    }
}