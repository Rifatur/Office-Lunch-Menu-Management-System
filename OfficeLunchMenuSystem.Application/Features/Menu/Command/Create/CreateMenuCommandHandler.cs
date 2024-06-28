using MediatR;
using OfficeLunchMenuSystem.Infrastructure.Data;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Create
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, Guid>
    {

        private readonly ApplicationDbContext _context;
        public CreateMenuCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public Task<Guid> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = new LunchMenu
            {
                Name = request.Name,
                Date = request.Date,
                Description = request.Description
            };
            return menu.Id;
        }
    }
}
