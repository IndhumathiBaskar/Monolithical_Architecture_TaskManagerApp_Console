using TaskManagerApp.Services;

TaskService taskService = new TaskService();

while(true)
{
    Console.WriteLine("=== TASK MANAGER (MONOLITHIC) ===");
    Console.WriteLine("1. Add Task");
    Console.WriteLine("2. Complete Task");
    Console.WriteLine("3. View All Tasks");
    Console.WriteLine("4. Exit");
    Console.Write("Choose: ");

    var choice = Console.ReadLine();

    switch(choice)
    {
        case "1":
            Console.Write("Enter Title: ");
            var title = Console.ReadLine();
            taskService.AddTask(title);
            break;

        case "2":
            Console.Write("Enter Task ID to Complete: ");
            int id = int.Parse(Console.ReadLine());
            taskService.CompleteTask(id);
            break;
        case "3":
            taskService.ShowAllTasks();
            break;
        case "4":
            return;
        
        default:
            Console.WriteLine("Invalid Chose!");
            break;
    }
}