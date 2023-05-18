using MediatR;
using System;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Command
{
    public class DeleteCheckListCommand : IRequest<Unit>
    {
        public int Id {get; set;}
    }
}