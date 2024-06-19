using System.ComponentModel.DataAnnotations;

namespace OfficeLunchMenuSystem.Domain.Entities.Common
{
    public class AuditableBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string? LastModifiedBy { get; set; }
        public DateTime LastModified { get; set; } = DateTime.UtcNow;
    }
}
