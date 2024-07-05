using MediatR;
using OfficeLunchMenuSystem.Application.Features.Menu.DTOs;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Queries.Get
{
    public class GetMenuByIdQuery : IRequest<LunchMenuDTO>
    {
        public Guid Id { get; set; }

    }
}
