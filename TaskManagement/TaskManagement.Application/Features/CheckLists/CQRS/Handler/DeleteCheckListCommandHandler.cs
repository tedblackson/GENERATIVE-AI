using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Exceptions;
using TaskManagement.Application.Features.CheckLists.CQRS.Command;
using TaskManagement.Domain;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Handler
{
    public class DeleteCheckListCommandHandler : IRequestHandler<DeleteCheckListCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ICheckListRepository _checkListRepository;

    public DeleteCheckListCommandHandler(IMapper mapper, ICheckListRepository checkListRepository)
    {
        _mapper = mapper;
        _checkListRepository = checkListRepository;
    }

    public async Task<Unit> Handle(DeleteCheckListCommand request, CancellationToken cancellationToken)
    {
        var checkList = await _checkListRepository.Get(request.Id);
        if (checkList == null)
        {
            throw new NotFoundException(nameof(CheckList), request.Id);
        }

        _checkListRepository.Delete(checkList);

        return Unit.Value;
    }
}
}