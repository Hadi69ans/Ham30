using Ham30.Server.Services.Common;
using Ham30.Server.Services.Identity.Requests;
using Ham30.Server.Services.Identity.Response;
using Ham30.Sheard.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}