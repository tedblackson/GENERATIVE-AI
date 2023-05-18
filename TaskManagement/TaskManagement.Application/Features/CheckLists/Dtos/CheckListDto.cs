using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Application.Features.CheckLists.Dtos
{
    
    public class CheckListDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int TaskId { get; set; }
        public bool IsCompleted { get; set; }
    }
}
