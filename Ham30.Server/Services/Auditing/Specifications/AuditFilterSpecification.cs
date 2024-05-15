using BlazorStore.Infrastructure.Models.Audit;
using BlazorStore.Application.Specifications.Base;

namespace Ham30.Server.Services.Auditing.Specifications
{
    public class AuditFilterSpecification : SpecificationBase<Audit>
    {
        public AuditFilterSpecification(string userId, string searchString, bool searchInOldValues, bool searchInNewValues)
        {
            if (!string.IsNullOrEmpty(searchString))
            {
                Criteria = p => (p.TableName.Contains(searchString) || searchInOldValues && p.OldValues.Contains(searchString) || searchInNewValues && p.NewValues.Contains(searchString)) && p.UserId == userId;
            }
            else
            {
                Criteria = p => p.UserId == userId;
            }
        }
    }
}