namespace TaskManager;

public class TaskView{
    public void ShowOptions(){
        Console.WriteLine("== Task Manager ==");
        Console.WriteLine("""
            1. Add Task
            2. View Task
            3. Mark Task as Completed
            4. Delete Task
            0. Exit
        """);
        Console.Write("Choose: ");
    }

    public string ChooseTask(){
        Console.Write("Task to Delete (title): ");
        return Console.ReadLine();
    }

    void ShowTask(TaskItem taskItem){
        string completion = taskItem.isCompleted ? "Completed" : "Incomplete";
        Console.WriteLine($"""
            Title: {taskItem.Title} - ({completion})
                Description: {taskItem.Description}
        """);
    }

    public void ShowAllTasks(List<TaskItem> taskItems){
        Console.WriteLine("\n=== Tasks ===");
        foreach(TaskItem taskItem in taskItems){
            ShowTask(taskItem);
        }
        Console.WriteLine("===========\n");
    }

    public TaskItem AddTask(){
        Console.Write("\nTitle: ");
        string? title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        return new TaskItem(){Title = title, Description=description};
    }
}