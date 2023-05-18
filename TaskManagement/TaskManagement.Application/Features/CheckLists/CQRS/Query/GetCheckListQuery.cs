using MediatR;
using System;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Query
{
    public class GetCheckListQuery : IRequest<CheckListDto>
{
    public int Id { get; set; }
}
}