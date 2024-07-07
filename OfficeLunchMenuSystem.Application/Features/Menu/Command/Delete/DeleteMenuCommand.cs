using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Delete
{
    public class DeleteMenuCommand : IRequest<Unit>
    {
        public Guid Id { get; set; }

    }
}
