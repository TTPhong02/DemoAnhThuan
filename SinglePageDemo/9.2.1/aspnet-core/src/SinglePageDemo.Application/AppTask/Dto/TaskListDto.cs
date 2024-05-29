using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities.Auditing;
using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.AppTask.Dto
{
    [AutoMapFrom(typeof(AppTasks))]
    public class TaskListDto:EntityDto,IHasCreationTime
    {
        public string TaskName { get; set; }
        public string TaskCode { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState  State { get; set; }
        public int UserId { get; set; }
    }
}
