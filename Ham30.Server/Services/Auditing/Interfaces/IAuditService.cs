using Ham30.Server.Services.Auditing.Response;
using Ham30.Sheard.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Ham30.Server.Services.Auditing.Interfaces
{
    public interface IAuditService
    {
        Task<IResult<IEnumerable<AuditResponse>>> GetCurrentUserTrailsAsync(string userId);

        // Task<IResult<string>> ExportToExcelAsync(string userId, string searchString = "", bool searchInOldValues = false, bool searchInNewValues = false);
    }
}
