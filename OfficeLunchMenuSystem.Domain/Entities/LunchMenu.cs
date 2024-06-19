using OfficeLunchMenuSystem.Domain.Entities.Common;

namespace OfficeLunchMenuSystem.Domain.Entities
{
    public class LunchMenu : AuditableBaseEntity
    {
        public string Name { get; set; } = default!;
        public DateTime Date { get; set; }
        public string Description { get; set; } = default!;
        public ICollection<LunchOption> LunchOptions { get; set; } = default!;



        // Parameterless constructor for EF Core
        private LunchMenu() { }
        public LunchMenu(string name, string description)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
        }
    }

}
