using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.CheckLists.CQRS.Command;
using TaskManagement.Domain;

namespace TaskManagement.Application.Features.Tasks.CQRS.Handler
{
    public class UpdateTaskCommandHandler : IRequestHandler<UpdateTaskCommand, Unit>
{
    private readonly IMapper _mapper;
    private readonly ITaskRepository _taskRepository;

    public UpdateTaskCommandHandler(IMapper mapper, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public Task<Unit> Handle(UpdateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<_Task>(request);
        _taskRepository.Update(task);
        return Task.FromResult(Unit.Value);
    }
}
}