using Abp.Application.Services.Dto;
using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.AppTask.Dto
{
    public class CreateAppTaskInput:EntityDto<int>
    {
        public string TaskName { get; set; }
        public string TaskCode { get; set; }
        public string TaskDescription { get; set; }
        public DateTime CreationTime { get; set; }
        public int UserId { get; set; }
    }
}
