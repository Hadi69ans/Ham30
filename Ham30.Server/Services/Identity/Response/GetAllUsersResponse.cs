using System.Collections.Generic;

namespace Ham30.Server.Services.Identity.Response
{
    public class GetAllUsersResponse
    {
        public IEnumerable<UserResponse> Users { get; set; }
    }
}