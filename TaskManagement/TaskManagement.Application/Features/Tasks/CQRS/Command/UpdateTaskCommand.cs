using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Features.Tasks.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Command
{
    public class UpdateTaskCommand : IRequest<Unit>
    {
       public UpdateTaskDto UpdateTaskDto {get; set;}
    }
}
