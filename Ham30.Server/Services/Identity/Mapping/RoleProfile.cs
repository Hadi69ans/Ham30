using AutoMapper;
using Ham30.Server.Services.Identity.Models;
using Ham30.Server.Services.Identity.Response;


namespace Ham30.Server.Services.Identity.Mapping
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, AppRole>().ReverseMap();
        }
    }
}