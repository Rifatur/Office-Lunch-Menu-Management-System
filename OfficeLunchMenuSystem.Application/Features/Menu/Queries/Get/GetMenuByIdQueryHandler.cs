using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Application.Features.Menu.DTOs;
using OfficeLunchMenuSystem.Domain.Entities;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Queries.Get
{
    public class GetMenuByIdQueryHandler : IRequestHandler<GetMenuByIdQuery, LunchMenuDTO>
    {
        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;

        public GetMenuByIdQueryHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<LunchMenuDTO> Handle(GetMenuByIdQuery request, CancellationToken cancellationToken)
        {
            var menu = await _repository.GetByIdAsync(request.Id);
            if (menu == null)
            {
                // Handle not found
            }
            return _mapper.Map<LunchMenuDTO>(menu);
        }

    }
}
