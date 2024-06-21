using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Application.Features.LunchMenu.DTOs;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Commands.Write
{
    public class CreateLunchMenuCommandHandler : IRequestHandler<CreateLunchMenuCommand, Guid>
    {
        private readonly IRepository<LunchMenuDTO> _repository;
        private readonly IMapper _mapper;
        public CreateLunchMenuCommandHandler(IRepository<LunchMenuDTO> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateLunchMenuCommand request, CancellationToken cancellationToken)
        {
            var menu = _mapper.Map<LunchMenuDTO>(request);
            await _repository.AddAsync(menu);
            return menu.Id;
        }
    }
}
