using AutoMapper;
using Ham30.Server.Services.Identity.Response;
using Ham30.Server.Services.Identity.Models;

namespace Ham30.Server.Services.Identity.Mapping
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, AppUser>().ReverseMap();
            CreateMap<ChatUserResponse, AppUser>().ReverseMap()
                .ForMember(dest => dest.EmailAddress, source => source.MapFrom(source => source.Email)); //Specific Mapping
        }
    }
}