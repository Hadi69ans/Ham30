using System.Collections.Generic;

namespace Ham30.Server.Services.Identity.Response
{
    public class GetAllRolesResponse
    {
        public IEnumerable<RoleResponse> Roles { get; set; }
    }
}