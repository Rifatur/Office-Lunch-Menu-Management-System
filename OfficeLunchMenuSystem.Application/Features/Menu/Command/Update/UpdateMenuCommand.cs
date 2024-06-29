using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Update
{
    public class UpdateMenuCommand : IRequest
    {
        public string Name { get; set; } = string.Empty;
        public DateTime Date { get; set; }
        public string Description { get; set; } = string.Empty;
    }
}
