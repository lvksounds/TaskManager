using TaskManaerAPI.Data;
using TaskManaerAPI.Models;
namespace TaskManaerAPI.Services
{
    public class TaskService
    {
        private readonly TaskContext _taskContext;

        public TaskService(TaskContext taskContext)
        {
            _taskContext = taskContext;
        }

        public async Task<TaskInfo> CreateTask(TaskInfo task)
        {
           await  _taskContext.Tasks.InsertOneAsync(task);
            return task;
        }
    }
}
