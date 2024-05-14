using AutoMapper;
using Ham30.Server.Services.Identity.Interfaces;
using Ham30.Server.Services.Identity.Models;

namespace Ham30.Server.Services.Identity.Mapping
{
    public class ChatHistoryProfile : Profile
    {
        public ChatHistoryProfile()
        {
            CreateMap<ChatHistory<IChatUser>, ChatHistory<AppUser>>().ReverseMap();
        }
    }
}