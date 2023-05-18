using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.CheckLists.CQRS.Query;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Handler
{
    public class GetCheckListsByTaskQueryHandler : IRequestHandler<GetCheckListsByTaskQuery, IEnumerable<CheckListDto>>
{
    private readonly IMapper _mapper;
    private readonly ICheckListRepository _checkListRepository;

    public GetCheckListsByTaskQueryHandler(IMapper mapper, ICheckListRepository checkListRepository)
    {
        _mapper = mapper;
        _checkListRepository = checkListRepository;
    }

    public Task<IEnumerable<CheckListDto>> Handle(GetCheckListsByTaskQuery request, CancellationToken cancellationToken)
    {
        var checkLists = _checkListRepository.GetCheckListByTask(request.TaskId);
        return Task.FromResult(_mapper.Map<IEnumerable<CheckListDto>>(checkLists));
    }
}
}