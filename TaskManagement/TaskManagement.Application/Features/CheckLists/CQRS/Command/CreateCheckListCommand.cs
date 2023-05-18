using MediatR;
using System;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Command
{
    public class CreateCheckListCommand : IRequest<int>
{
    public CreateCheckListDto CreateCheckListDto{get; set;}
   
}
}