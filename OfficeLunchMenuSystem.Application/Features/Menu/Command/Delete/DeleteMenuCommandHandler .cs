using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Domain.Entities;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Delete
{
    public class DeleteMenuCommandHandler : IRequestHandler<DeleteMenuCommand, Unit>
    {
        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;
        public DeleteMenuCommandHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<Unit> Handle(DeleteMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.Id);
            if (menu == null)
            {
                // Handle not found scenario, possibly throw an exception
                throw new Exception("Menu not found");
            }
            await _repository.DeleteAsync(menu);

            return Unit.Value;

        }

    }
}
