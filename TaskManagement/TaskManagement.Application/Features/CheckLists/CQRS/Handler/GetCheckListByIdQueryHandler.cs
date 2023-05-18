using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.CheckLists.CQRS.Query;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Handler
{
   public class GetCheckListQueryHandler : IRequestHandler<GetCheckListQuery, CheckListDto>
{
    private readonly IMapper _mapper;
    private readonly ICheckListRepository _checkListRepository;

    public GetCheckListQueryHandler(IMapper mapper, ICheckListRepository checkListRepository)
    {
        _mapper = mapper;
        _checkListRepository = checkListRepository;
    }

    public async Task<CheckListDto> Handle(GetCheckListQuery request, CancellationToken cancellationToken)
    {
        var checkList = await _checkListRepository.Get(request.Id);


          return _mapper.Map<CheckListDto>(checkList);
          
    }
}
}