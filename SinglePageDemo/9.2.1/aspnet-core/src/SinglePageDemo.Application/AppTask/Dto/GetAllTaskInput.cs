using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.AppTask.Dto
{
    public class GetAllTaskInput
    {
        public TaskState? State { get; set; }
    }
}
