﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Features.Tasks.Dtos;

namespace TaskManagement.Application.Features.CheckLists.CQRS.Command
{
    public class CreateTaskCommand : IRequest<int>
    {
        public CreateTaskDto CreateTaskDto {get; set;}
    }
}
