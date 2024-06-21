using MediatR;
using OfficeLunchMenuSystem.Application.Features.LunchMenu.DTOs;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Queries.List
{
    public class ListLunchMenuQueryHandler : IRequestHandler<ListLunchMenuQuery, IEnumerable<LunchMenuDTO>>
    {
        private readonly IRepository<LunchMenuDTO> _repository;
        public ListLunchMenuQueryHandler(IRepository<LunchMenuDTO> repository)
        {
            _repository = repository;
        }
        public async Task<IEnumerable<LunchMenuDTO>> Handle(ListLunchMenuQuery request, CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync();

        }
    }
}
