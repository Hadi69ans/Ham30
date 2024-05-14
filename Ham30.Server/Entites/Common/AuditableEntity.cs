﻿using Microsoft.AspNetCore.Http.HttpResults;
using System;

namespace Ham30.Server.Entites.Common
{
    public abstract class AuditableEntity<TId> : IAuditableEntity<TId> 
    {
        public TId Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }


        protected AuditableEntity()
        {
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }
    }

}