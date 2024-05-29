using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Abp.Timing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.Entities
{
    [Table("AppTasks")]
    public class AppTasks:Entity<int>,IHasCreationTime
    {
        public string TaskCode { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreationTime { get; set; }
        public TaskState State { get; set; }
        public int UserId { get; set; }
        public AppTasks()
        {
            CreationTime = Clock.Now;
            State = TaskState.Open;
        }

        public AppTasks(int userId,string name, string code, string description = null)
            : this()
        {
            TaskCode = code;
            TaskName = name;
            TaskDescription = description;
            UserId = userId;
        }
    }
    public enum TaskState {
        Open = 0,
        Completed = 1
    }

}
