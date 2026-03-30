using TaskManagementAPI.Models;

namespace TaskManagementAPI.Repositories
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem GetById(int id);
        TaskItem Add(TaskItem task);
        TaskItem Update(TaskItem task);
        void Delete(int id);
    }
}