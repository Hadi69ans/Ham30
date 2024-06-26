﻿using System.ComponentModel.DataAnnotations;

namespace Ham30.Server.Services.Identity.Response
{
    public class RoleResponse
    {
        public string Id { get; set; }

        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}