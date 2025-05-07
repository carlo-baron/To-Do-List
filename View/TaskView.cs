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
        Console.Write("Task to Delete (Id): ");
        return Console.ReadLine();
    }

    void ShowTask(TaskItem taskItem){
        string completion = taskItem.IsCompleted ? "Completed" : "Incomplete";
        Console.WriteLine($"""
            {taskItem.Id}. Title: {taskItem.Title} - ({completion})
                Description: {taskItem.Description}
        """);
    }

    public void ShowAllTasks(List<TaskItem> taskItems){
        Console.WriteLine("\n========= Tasks =========");
        foreach(TaskItem taskItem in taskItems){
            ShowTask(taskItem);
        }
        Console.WriteLine("==========================\n");
    }

    public (string?, string?) AddTask(){
        Console.Write("\nTitle: ");
        string? title = Console.ReadLine();

        Console.Write("Description: ");
        string? description = Console.ReadLine();

        return (title, description);
    }
}