using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.CheckLists.CQRS.Command;
using TaskManagement.Domain;

namespace TaskManagement.Application.Features.Tasks.CQRS.Handler
{
   public class CreateTaskCommandHandler : IRequestHandler<CreateTaskCommand, int>
{
    private readonly IMapper _mapper;
    private readonly ITaskRepository _taskRepository;

    public CreateTaskCommandHandler(IMapper mapper, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public Task<int> Handle(CreateTaskCommand request, CancellationToken cancellationToken)
    {
        var task = _mapper.Map<_Task>(request);
        _taskRepository.Add(task);
        return Task.FromResult(task.Id);
    }
}
}