namespace Ham30.Server.Services.Common.Interface
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}