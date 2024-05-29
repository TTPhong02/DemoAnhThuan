using Abp.Application.Services;
using Abp.Application.Services.Dto;
using SinglePageDemo.AppTask.Dto;
using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglePageDemo.AppTask
{
    public interface IAppTasksService:IApplicationService
    {
        Task<ListResultDto<TaskListDto>> GetAll(GetAllTaskInput input);
        Task<AppTasks> CreateTask(CreateAppTaskInput input);
        Task<AppTasks> UpdateTask(UpdateTaskInput input);
        Task DeleteTask(DeleteTaskInput input);
    }
}
