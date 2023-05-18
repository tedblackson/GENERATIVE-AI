using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Application.Features.CheckLists.Dtos;
using TaskManagement.Application.Features.Tasks.Dtos;
using TaskManagement.Domain;

namespace TaskManagement.Application.Profiles
{
    public class MappingProfile : Profile
    {

        public MappingProfile() {

            CreateMap<CheckList, CheckListDto>().ReverseMap();
            CreateMap<CheckList, UpdateCheckListDto>().ReverseMap();
            CreateMap<CheckList, CreateCheckListDto>().ReverseMap();

            CreateMap<_Task, TaskDto>().ReverseMap();
            CreateMap<_Task, CreateTaskDto>().ReverseMap();
            CreateMap<Task, UpdateTaskDto>().ReverseMap();

            
        }
    }
}
