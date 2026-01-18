using TodoAppWPF;

var todoList = new TodoList();

while (true)
{
    Console.Clear();
    Console.WriteLine("=== TO DO APP ===");
    Console.WriteLine();
    Console.WriteLine("1) Add task");
    Console.WriteLine("2) Remove task");
    Console.WriteLine("3) View tasks");
    Console.WriteLine("0) Exit");
    Console.Write("Choose: ");

    var choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            AddTask(todoList);
            break;

        case "2":
            RemoveTask(todoList);
            break;

        case "3":
            ViewTasks(todoList);
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Invalid choice.");
            Pause();
            break;
    }
}






static void AddTask(TodoList todoList)
{
    Console.Clear();
    Console.WriteLine("=== ADD TASK ===");
    Console.Write("Task: ");

    var task = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(task))
        todoList.AddTask(task);

    Console.WriteLine("Done.");
    Pause();
}

static void RemoveTask(TodoList todoList)
{
    Console.Clear();
    Console.WriteLine("=== REMOVE TASK ===");

    var tasks = todoList.GetAllTasks();
    if (tasks.Count == 0)
    {
        Console.WriteLine("(no tasks to remove)");
        Pause();
        return;
    }

   
    for (int i = 0; i < tasks.Count; i++)
        Console.WriteLine($"{i + 1}) {tasks[i]}");

    Console.WriteLine();
    Console.Write("Task number to remove: ");
    var input = Console.ReadLine();

    if (int.TryParse(input, out int number))
    {
        int position = number - 1;      
        todoList.RemoveTask(position); 
    }

    Console.WriteLine("Done.");
    Pause();
}

static void ViewTasks(TodoList todoList)
{
    Console.Clear();
    Console.WriteLine("=== TASKS ===");

    var tasks = todoList.GetAllTasks();
    if (tasks.Count == 0)
    {
        Console.WriteLine("(no tasks yet)");
        Pause();
        return;
    }

    for (int i = 0; i < tasks.Count; i++)
        Console.WriteLine($"{i + 1}) {tasks[i]}");

    Pause();
}

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("Press ENTER to continue...");
    Console.ReadLine();
}
