using TaskManagementAPI.Models;
using TaskManagementAPI.Repositories;

namespace TaskManagementAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TaskItem> GetTasks()
        {
            return _repository.GetAll();
        }

        public TaskItem GetTask(int id)
        {
            return _repository.GetById(id);
        }

        public TaskItem CreateTask(TaskItem task)
        {
            return _repository.Add(task);
        }

        public TaskItem UpdateTask(TaskItem task)
        {
            return _repository.Update(task);
        }

        public void DeleteTask(int id)
        {
            _repository.Delete(id);
        }
    }
}