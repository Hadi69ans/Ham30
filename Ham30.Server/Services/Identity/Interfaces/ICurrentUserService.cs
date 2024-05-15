
using Ham30.Server.Services.Common;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}