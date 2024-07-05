using MediatR;
using OfficeLunchMenuSystem.Application.Features.Menu.DTOs;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Queries.List
{
    public class ListMenuQuery : IRequest<IEnumerable<LunchMenuDTO>> { }


}
