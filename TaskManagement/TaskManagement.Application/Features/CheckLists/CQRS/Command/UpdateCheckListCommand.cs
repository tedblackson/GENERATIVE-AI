using MediatR;
using System;
using TaskManagement.Application.Features.CheckLists.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Command
{
    public class UpdateCheckListCommand : IRequest<Unit>
    {
        public UpdateCheckListDto UpdateCheckListDto { get; set; }
      
}
}