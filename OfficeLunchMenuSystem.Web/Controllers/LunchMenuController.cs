using MediatR;
using Microsoft.AspNetCore.Mvc;
using OfficeLunchMenuSystem.Application.Features.Menu.Command.Create;

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

            return View();
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateMenuCommand command)
        {
            if (ModelState.IsValid)
            {
                var productId = await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }
    }
}
