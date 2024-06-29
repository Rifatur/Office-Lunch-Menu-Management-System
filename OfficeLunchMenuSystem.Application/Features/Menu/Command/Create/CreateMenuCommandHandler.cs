using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Domain.Entities;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Create
{
    public class CreateMenuCommandHandler : IRequestHandler<CreateMenuCommand, Guid>
    {

        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;
        public CreateMenuCommandHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateMenuCommand request, CancellationToken cancellationToken)
        {
            var Menu = _mapper.Map<LunchMenu>(request);
            await _repository.AddAsync(Menu);
            return Menu.Id;
        }
    }
}
