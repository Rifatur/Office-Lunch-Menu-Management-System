using MediatR;
using OfficeLunchMenuSystem.Application.Features.LunchMenu.DTOs;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Queries.List
{
    public class ListLunchMenuQueryHandler : IRequestHandler<ListLunchMenuQuery, List<LunchMenuDTO>>
    {
        public Task<List<LunchMenuDTO>> Handle(ListLunchMenuQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
