
using Ham30.Server.Services.Identity.Response;
using System.Collections.Generic;

namespace Ham30.Server.Services.Identity.Requests
{
    public class UpdateUserRolesRequest
    {
        public string UserId { get; set; }
        public IList<UserRoleModel> UserRoles { get; set; }
    }
}