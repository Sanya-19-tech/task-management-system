using TaskManagementAPI.Models;

namespace TaskManagementAPI.Services
{
    public interface ITaskService
    {
        IEnumerable<TaskItem> GetTasks();
        TaskItem GetTask(int id);
        TaskItem CreateTask(TaskItem task);
        TaskItem UpdateTask(TaskItem task);
        void DeleteTask(int id);
    }
}