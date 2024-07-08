using MediatR;
using Microsoft.AspNetCore.Mvc;
using OfficeLunchMenuSystem.Application.Features.Menu.Command.Create;
using OfficeLunchMenuSystem.Application.Features.Menu.Command.Delete;
using OfficeLunchMenuSystem.Application.Features.Menu.Command.Update;
using OfficeLunchMenuSystem.Application.Features.Menu.Queries.Get;
using OfficeLunchMenuSystem.Application.Features.Menu.Queries.List;

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

            var menus = await _mediator.Send(new ListMenuQuery());
            return View(menus);

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
        [HttpGet("{id}")]
        public async Task<IActionResult> MenuById(Guid id)
        {
            var Menu = await _mediator.Send(new GetMenuByIdQuery { Id = id });
            if (Menu == null)
            {
                return NotFound();
            }
            return View(Menu);

        }



        public async Task<IActionResult> Delete(Guid id)
        {
            await _mediator.Send(new DeleteMenuCommand { Id = id });
            return RedirectToAction("Index", "LunchMenu");
        }
        public async Task<IActionResult> Edit(Guid id)
        {
            var menus = await _mediator.Send(new GetMenuByIdQuery { Id = id });
            if (menus == null)
            {
                return NotFound();
            }
            var command = new UpdateMenuCommand
            {
                Id = menus.Id,
                Name = menus.Name,
                Date = menus.Date,
                Description = menus.Description
            };
            return View(command);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(UpdateMenuCommand command)
        {
            if (ModelState.IsValid)
            {
                await _mediator.Send(command);
                return RedirectToAction(nameof(Index));
            }
            return View(command);
        }




    }
}
