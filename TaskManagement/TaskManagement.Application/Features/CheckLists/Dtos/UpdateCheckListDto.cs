using System;

namespace TaskManagement.Application.Features.CheckLists.Dtos
{
    public class UpdateCheckListDto 
    {
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public int TaskId { get; set; }
    public bool IsCompleted { get; set; }
    }
}