using AutoMapper;
using MediatR;
using System;
using TaskManagement.Application.Contracts.Persistence;
using TaskManagement.Application.Features.Tasks.CQRS.Query;
using TaskManagement.Application.Features.Tasks.Dtos;

namespace TaskManagement.Application.Features.Tasks.CQRS.Handler
{
    public class GetTaskByIdQueryHandler : IRequestHandler<GetTaskByIdQuery, TaskDto>
{
    private readonly IMapper _mapper;
    private readonly ITaskRepository _taskRepository;

    public GetTaskByIdQueryHandler(IMapper mapper, ITaskRepository taskRepository)
    {
        _mapper = mapper;
        _taskRepository = taskRepository;
    }

    public Task<TaskDto> Handle(GetTaskByIdQuery request, CancellationToken cancellationToken)
    {
        var task = _taskRepository.Get(request.Id);
        return Task.FromResult(_mapper.Map<TaskDto>(task));
    }
}
}