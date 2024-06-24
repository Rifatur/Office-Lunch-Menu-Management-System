using MediatR;
using Microsoft.AspNetCore.Mvc;
using OfficeLunchMenuSystem.Application.Features.LunchMenu.Queries.List;

namespace OfficeLunchMenuSystem.Web.Controllers
{
    public class LunchMenuController : Controller
    {
        private readonly IMediator _mediator;
        public LunchMenuController(IMediator mediator)
        {
            _mediator = mediator;
        }
        public async Task<IActionResult> Index(CancellationToken cancellationToken)
        {
            var result = await _mediator.Send(new ListLunchMenuQuery(), cancellationToken);
            return View(result);
        }
        public async Task<IActionResult> Createpost()
        {
            return View();
        }
    }
}
