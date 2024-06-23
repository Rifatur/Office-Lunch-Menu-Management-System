using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Commands.Delete
{
    public class DeleteLunchMenuCommandHandler : IRequestHandler<DeleteLunchMenuCommand>
    {

        Task IRequestHandler<DeleteLunchMenuCommand>.Handle(DeleteLunchMenuCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
