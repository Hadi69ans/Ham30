using Ham30.Server.Services.Identity.Models;
using Ham30.Server.Services.Identity.Response;
using Ham30.Sheard.Wrapper;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace Ham30.Server.Services.Chat.Interfaces
{
    public interface IChatService
    {
        Task<Result<IEnumerable<ChatUserResponse>>> GetChatUsersAsync(string userId);

        Task<Sheard.Wrapper.IResult> SaveMessageAsync(ChatHistory<IChatUser> message);

        Task<Result<IEnumerable<ChatHistoryResponse>>> GetChatHistoryAsync(string userId, string contactId);
    }
}