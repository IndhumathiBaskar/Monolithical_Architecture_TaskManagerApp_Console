using TaskManagerApp.Models;

namespace TaskManagerApp.Repository
{
    public class TaskRepository
    {
        private List<TaskItem> tasks = new List<TaskItem>();
        private int _idCounter = 1;

        public List<TaskItem> GetAll()
        {
            return tasks;
        }

        public TaskItem Add(string title)
        {
            var task = new TaskItem()
            {
                Id = _idCounter++,
                Title = title,
                IsCompleted = false
            };

            tasks.Add(task);

            return task;
        }
            
        public bool MarkCompleted(int id)
        {
            var task = tasks.FirstOrDefault(t => t.Id == id);

            if (task == null)
            {
                return false;
            }
            
            task.IsCompleted = true;

            return true;
        }
    }
}