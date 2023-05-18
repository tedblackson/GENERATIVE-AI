using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.Tasks.CQRS.Command;

namespace TaskManagement.Application.Features.Tasks.CQRS.Handler
{
    public class DeleteTaskCommandHandler : IRequestHandler<DeleteTaskCommand, Unit>
{
    private readonly ITaskRepository _taskRepository;

    public DeleteTaskCommandHandler(ITaskRepository taskRepository)
    {
        _taskRepository = taskRepository;
    }

    public async  Task<Unit> Handle(DeleteTaskCommand request, CancellationToken cancellationToken)
    {
            var task = await _taskRepository.Get(request.Id);

        _taskRepository.Delete(task);
        return Unit.Value;
    }
}
}