using MediatR;

namespace OfficeLunchMenuSystem.Application.Features.LunchMenu.Commands.Write
{
    public class CreateLunchMenuCommand : IRequest<Guid>
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
    }

}
