

namespace Ham30.Server.Services.Common
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}