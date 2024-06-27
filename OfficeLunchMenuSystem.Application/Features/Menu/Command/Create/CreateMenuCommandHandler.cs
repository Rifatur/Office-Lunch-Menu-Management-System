using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Create
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, Guid>
    {



        public Task<Guid> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
