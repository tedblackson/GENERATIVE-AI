using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Exceptions;
using TaskManagement.Application.Features.CheckLists.CQRS.Command;
using TaskManagement.Domain;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Handler
{
    public class UpdateCheckListCommandHandler : IRequestHandler<UpdateCheckListCommand, Unit>
    {
        private readonly IMapper _mapper;
        private readonly ICheckListRepository _checkListRepository;

        public UpdateCheckListCommandHandler(IMapper mapper, ICheckListRepository checkListRepository)
        {
            _mapper = mapper;
            _checkListRepository = checkListRepository;
        }

        public async Task<Unit> Handle(UpdateCheckListCommand request, CancellationToken cancellationToken)
        {
            var checkList = await _checkListRepository.Get(request.UpdateCheckListDto.Id);
            if (checkList == null)
            {
                throw new NotFoundException(nameof(CheckList), request.UpdateCheckListDto.Id);
            }

            _mapper.Map(request.UpdateCheckListDto, checkList);

            await _checkListRepository.Update(checkList);

            return Unit.Value;
        }
    }
}