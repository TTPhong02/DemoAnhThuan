using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using Abp.ObjectMapping;
using AutoMapper.Internal.Mappers;
using Microsoft.EntityFrameworkCore;
using SinglePageDemo.AppTask.Dto;
using SinglePageDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;


namespace SinglePageDemo.AppTask
{
    public class AppTaskService : SinglePageDemoAppServiceBase, IAppTasksService
    {
        private readonly IRepository<AppTasks> _appTaskRepository;

        public AppTaskService(IRepository<AppTasks> appTaskRepository)
        {
            _appTaskRepository = appTaskRepository;
        }

        public async Task<AppTasks> CreateTask(CreateAppTaskInput input)
        {
            //var t = ObjectMapper.Map<AppTasks>(input);
            var task = new AppTasks
            {
                TaskCode = input.TaskCode,
                TaskDescription = input.TaskDescription,
                TaskName = input.TaskName,
                UserId = input.UserId,
            };
            var createdTaskApp = await _appTaskRepository.InsertAsync(task);
            return createdTaskApp;
        }

        public async Task DeleteTask(DeleteTaskInput input)
        {
            var idDelete = input.id;
            await _appTaskRepository.DeleteAsync(idDelete);
        }

        //public async Task<ListResultDto<AppTasks>> GetAll(GetAllTaskInput input)
        //{
        //    var tasks = await _appTaskRepository.GetAllAsync();
        //}

        public async Task<ListResultDto<TaskListDto>> GetAll(GetAllTaskInput input)
        {
            var task = await _appTaskRepository
                .GetAll()
                .WhereIf(input.State.HasValue, t => t.State == input.State.Value)
                .OrderByDescending(t => t.CreationTime)
                .ToListAsync();
            return new ListResultDto<TaskListDto>(
                ObjectMapper.Map<List<TaskListDto>>(task)
            );
        }

        public async Task<AppTasks> UpdateTask(UpdateTaskInput input)
        {
            var task = new AppTasks
            {
                TaskCode = input.TaskCode,
                TaskDescription = input.TaskDescription,
                TaskName = input.TaskName,
                UserId = input.UserId,
            };
            var updateTaskApp = await _appTaskRepository.UpdateAsync(task);
            return updateTaskApp;
        }
    }
}
