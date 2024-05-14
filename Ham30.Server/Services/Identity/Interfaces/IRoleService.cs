using Ham30.Server.Services.Common;
using Ham30.Server.Services.Identity.Requests;
using Ham30.Server.Services.Identity.Response;
using Ham30.Sheard.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface IRoleService : IService
    {
        Task<Result<List<RoleResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleResponse>> GetByIdAsync(string id);

        Task<Result<string>> SaveAsync(RoleRequest request);

        Task<Result<string>> DeleteAsync(string id);

        Task<Result<PermissionResponse>> GetAllPermissionsAsync(string roleId);

        Task<Result<string>> UpdatePermissionsAsync(PermissionRequest request);
    }
}