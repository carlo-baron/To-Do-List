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
                    break;
                case "4":
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid Input\n");
                    break;

            }
        }
    }
}