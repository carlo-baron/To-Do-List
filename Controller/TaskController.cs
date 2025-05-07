namespace TaskManager;

public class TaskController{
    List<TaskItem> taskItems = new List<TaskItem>();
    TaskView taskView = new TaskView();

    public void Run(){
        while(true){
            taskView.ShowOptions();
            string? choice = Console.ReadLine();

            switch(choice){
                case "1":
                    (string? Title, string? Description) newTask = taskView.AddTask();
                    if(string.IsNullOrWhiteSpace(newTask.Title) && string.IsNullOrWhiteSpace(newTask.Description)){
                        Console.WriteLine("Cannot create an empty task");
                        break;
                    }
                    taskItems.Add(new TaskItem(){Id=taskItems.Count()+1, Title = newTask.Title, Description=newTask.Description});
                    Console.WriteLine("Task Added.\n");
                    break;
                case "2":
                    taskView.ShowAllTasks(taskItems);
                    break;
                case "3":
                    Mark(taskView.ChooseTask());
                    break;
                case "4":
                    Delete(taskView.ChooseTask());
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid Input.\n");
                    break;

            }
        }
    }

    void Delete(string Id){
        TaskItem? itemToRemove = FindItemById(Id); 
        
        if(itemToRemove == null){
            Console.WriteLine("Task not found.\n");
            return;
        }

        taskItems.Remove(itemToRemove);
        Console.WriteLine($"Task '{itemToRemove.Title}' removed.\n");
}

    void Mark(string Id){
        TaskItem? itemToRemove = FindItemById(Id);
        if(itemToRemove == null){
            Console.WriteLine("Task not found.\n");
            return;
        }
        itemToRemove.IsCompleted = true;
        Console.WriteLine($"Task '{itemToRemove.Title}' marked as completed.\n");
    }

    TaskItem? FindItemById(string title){
        foreach(TaskItem taskItem in taskItems){
            string itemId = taskItem.Id.ToString();
            if(itemId == title){
                return taskItem;
            }
        }

        return null;
    }
}