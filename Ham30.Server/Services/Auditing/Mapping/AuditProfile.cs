using AutoMapper;
using BlazorStore.Application.Responses.Audit;
using Ham30.Server.Services.Auditing.Models;

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