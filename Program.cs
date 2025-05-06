namespace TaskManager;

class Program{
    static void Main(string[] args){
        TaskController taskController = new TaskController();
        taskController.Run();
    }
}