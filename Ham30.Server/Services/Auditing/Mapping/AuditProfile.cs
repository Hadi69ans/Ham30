using AutoMapper;
using Ham30.Server.Services.Auditing.Models;
using Ham30.Server.Services.Auditing.Response;

namespace Ham30.Server.Services.Auditing.Mapping
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}