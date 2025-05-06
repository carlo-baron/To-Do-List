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

    void ShowTask(TaskItem taskItem){
        Console.WriteLine($"""
            Title: {taskItem.Title}
                Description: {taskItem.Description}
        """);
    }

    public void ShowAllTasks(List<TaskItem> taskItems){
        Console.WriteLine("== Tasks ==");
        foreach(TaskItem taskItem in taskItems){
            ShowTask(taskItem);
        }
        Console.WriteLine("===========");
    }

    public TaskItem AddTask(){
        Console.Write("Title: ");
        string? title = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        return new TaskItem(){Title = title, Description=description};
    }
}