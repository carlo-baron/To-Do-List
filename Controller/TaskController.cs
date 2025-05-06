namespace TaskManager;

public class TaskController{
    List<TaskItem> taskItems = new List<TaskItem>();
    TaskView taskView = new TaskView();

    public void Run(){
        while(true){
            taskView.ShowOptions();
            string choice = Console.ReadLine();

            switch(choice){
                case "1":
                    taskItems.Add(taskView.AddTask());
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

    void Delete(string Title){
        try{
            taskItems.Remove(FindItemInList(Title));
            Console.WriteLine($"Task '{Title}' removed.");
        }catch{
            Console.WriteLine("Task not found.");
        }
    }

    void Mark(string Title){
        try{
            FindItemInList(Title).isCompleted = true;
            Console.WriteLine($"Task '{Title}' marked as completed.");
        }catch{
            Console.WriteLine("Task not found.");
        }
    }

    TaskItem FindItemInList(string title){
        foreach(TaskItem taskItem in taskItems){
            if(taskItem.Title == title){
                return taskItem;
            }
        }

        return null;
    }
}