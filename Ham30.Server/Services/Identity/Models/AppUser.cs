﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Ham30.Server.Entites.Common;
using Ham30.Server.Services.Chat.Interfaces;
using Ham30.Server.Services.Chat.Models;

namespace Ham30.Server.Services.Identity.Models
{
    public class AppUser : IdentityUser<string>, IChatUser, IAuditableEntity<string>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }
        public string CreatedBy { get; set; }

        [Column(TypeName = "text")]
        public string ProfilePictureDataUrl { get; set; }

        public DateTime CreatedOn { get; set; }

        public string LastModifiedBy { get; set; }

        public DateTime? LastModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
        public bool IsActive { get; set; }
        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<ChatHistory<AppUser>> ChatHistoryFromUsers { get; set; }
        public virtual ICollection<ChatHistory<AppUser>> ChatHistoryToUsers { get; set; }

        public AppUser()
        {
            ChatHistoryFromUsers = new HashSet<ChatHistory<AppUser>>();
            ChatHistoryToUsers = new HashSet<ChatHistory<AppUser>>();
        }
    }
}