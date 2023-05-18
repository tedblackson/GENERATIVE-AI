using MediatR;
using System;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Query
{
    public class GetCheckListsByTaskQuery : IRequest<List<CheckListDto>>
    {
        public int TaskId { get; set; }
    }
}