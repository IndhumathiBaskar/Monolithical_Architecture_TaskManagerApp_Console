using TaskManagerApp.Repository;


namespace TaskManagerApp.Services
{
    public class TaskService
    {
        private readonly TaskRepository _repository;

        public TaskService()
        {
            _repository = new TaskRepository();
        }

        public void 4AddTask(string title)
        {
            var task = _repository.Add(title);
            Console.WriteLine($"Task Added: {task.Id} - {task.Title}");
        }

        public void CompleteTask(int id)
        {
            bool result = _repository.MarkCompleted(id);

            if(result)
            {
                Console.WriteLine("Task mark as completed");
            }
            else
            {
                Console.WriteLine("Task not found!");
            }
        }

        public void ShowAllTasks()
        {
            var task = _repository.GetAll();

            Console.WriteLine("\n Your Tasks:");
            Console.WriteLine("-----------------------");

            foreach(var t in task)
            {
                Console.WriteLine($"{t.Id}. {t.Title} | Complted: {t.IsCompleted}");
            }

            Console.WriteLine("--------------------------\n");
        }
    }
}