using OfficeLunchMenuSystem.Domain.Entities.Common;

namespace OfficeLunchMenuSystem.Domain.Entities
{
    public class LunchOption : AuditableBaseEntity
    {
        public Guid MenuId { get; set; }
        public string OptionName { get; set; } = default!;
        public string Description { get; set; } = default!;
        public LunchMenu Menu { get; set; } = default!;
    }
}
