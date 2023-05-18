using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.CheckLists.CQRS.Command;
using TaskManagement.Domain;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Handler
{
 public class CreateCheckListCommandHandler : IRequestHandler<CreateCheckListCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ICheckListRepository _checkListRepository;

    public CreateCheckListCommandHandler(IMapper mapper, ICheckListRepository checkListRepository)
    {
        _mapper = mapper;
        _checkListRepository = checkListRepository;
    }

    public async Task<int> Handle(CreateCheckListCommand request, CancellationToken cancellationToken)
    {
        var checkList = _mapper.Map<CheckList>(request);

        await _checkListRepository.Add(checkList);

        return checkList.Id;
    }
}
}