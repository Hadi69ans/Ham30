﻿using System;
using Ham30.Server.Entites.Common;
using Microsoft.AspNetCore.Identity;

namespace Ham30.Server.Services.Identity.Models
{
    public class AppRoleClaim : IdentityRoleClaim<string>, IAuditableEntity<int>
    {
        public string Description { get; set; }
        public string Group { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public virtual AppRole Role { get; set; }

        public AppRoleClaim() : base()
        {
        }

        public AppRoleClaim(string roleClaimDescription = null, string roleClaimGroup = null) : base()
        {
            Description = roleClaimDescription;
            Group = roleClaimGroup;
        }
    }
}