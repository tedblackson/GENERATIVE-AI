using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.Features.Tasks.CQRS.Command
{
    public class DeleteTaskCommand : IRequest<Unit>
    {
        public int Id { get; set; }
    }
}
