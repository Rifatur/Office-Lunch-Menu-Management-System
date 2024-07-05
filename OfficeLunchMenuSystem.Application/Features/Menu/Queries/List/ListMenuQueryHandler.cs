using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Application.Features.Menu.DTOs;
using OfficeLunchMenuSystem.Domain.Entities;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Queries.List
{
    public class ListMenuQueryHandler : IRequestHandler<ListMenuQuery, IEnumerable<LunchMenuDTO>>
    {
        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;
        public ListMenuQueryHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<IEnumerable<LunchMenuDTO>> Handle(ListMenuQuery request, CancellationToken cancellationToken)
        {
            var Menus = await _repository.GetAllAsync();
            return _mapper.Map<IEnumerable<LunchMenuDTO>>(Menus);

        }
    }
}
