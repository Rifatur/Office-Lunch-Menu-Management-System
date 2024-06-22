using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Commands.Delete
{
    public class DeleteLunchMenuCommand(Guid Id) : IRequest;

}
