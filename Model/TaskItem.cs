namespace TaskManager;

public class TaskItem{
    public string? Title {get;set;}
    public required string Description {get; set;}
    public bool isCompleted {get;set;} = false;
}