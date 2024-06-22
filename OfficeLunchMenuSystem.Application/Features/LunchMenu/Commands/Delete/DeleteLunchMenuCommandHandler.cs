using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Commands.Delete
{
    public class DeleteLunchMenuCommandHandler : IRequestHandler<DeleteLunchMenuCommand>
    {
        public Task<Unit> Handle(DeleteLunchMenuCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
