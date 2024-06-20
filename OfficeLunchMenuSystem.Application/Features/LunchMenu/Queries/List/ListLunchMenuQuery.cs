using MediatR;
using OfficeLunchMenuSystem.Application.Features.LunchMenu.DTOs;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Queries.List
{
    public record ListLunchMenuQuery : IRequest<List<LunchMenuDTO>>;

}
