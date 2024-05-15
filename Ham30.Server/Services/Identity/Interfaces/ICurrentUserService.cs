using Ham30.Server.Services.Common.Interface;

namespace Ham30.Server.Services.Identity.Interfaces
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}