using AutoMapper;
using MediatR;
using OfficeLunchMenuSystem.Domain.Entities;
using OfficeLunchMenuSystem.Domain.Repository;

namespace OfficeLunchMenuSystem.Application.Features.Menu.Command.Update
{
    public class UpdateMenuCommandHandler : IRequestHandler<UpdateMenuCommand, Unit>
    {
        private readonly IRepository<LunchMenu> _repository;
        private readonly IMapper _mapper;
        public UpdateMenuCommandHandler(IRepository<LunchMenu> repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public async Task<Unit> Handle(UpdateMenuCommand request, CancellationToken cancellationToken)
        {
            var Mneus = await _repository.GetByIdAsync(request.Id);
            if (Mneus == null) throw new Exception("Product not found");

            _mapper.Map(request, Mneus);
            await _repository.UpdateAsync(Mneus);

            return Unit.Value;
        }
    }
}
