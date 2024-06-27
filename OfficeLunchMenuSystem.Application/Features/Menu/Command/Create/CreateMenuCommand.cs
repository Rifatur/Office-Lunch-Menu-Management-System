using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Create
{
    public class CreateMenuCommand : IRequest<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
