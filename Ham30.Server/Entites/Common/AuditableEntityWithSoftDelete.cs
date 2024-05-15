using System;

namespace Ham30.Server.Entites.Common
{
    public abstract class AuditableEntityWithSoftDelete<TId> : IAuditableEntity<TId>, ISoftDelete
    {
        public TId Id { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime? LastModifiedOn { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedOn { get; set; }

        protected AuditableEntityWithSoftDelete()
        {
            CreatedOn = DateTime.UtcNow;
            LastModifiedOn = DateTime.UtcNow;
        }
    }
}