using OfficeLunchMenuSystem.Domain.Entities.Common;

namespace OfficeLunchMenuSystem.Domain.Entities
{
    public class LunchMenu : AuditableBaseEntity
    {
        public string Name { get; set; } = default!;
        public DateTime Date { get; set; }
        public string Description { get; set; } = default!;
        public ICollection<LunchOption> LunchOptions { get; set; } = default!;

    }

}
