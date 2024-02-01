namespace Bootcamp_E01.types;


public class TaskType
{
    public required string Title { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get;  }
    public required DateTime DeadLine { get; set; } 
    public Priority Priority { get; set; }
    public bool IsCompleted { get; set; }
    public DateTime? CompletionDate { get; set; }
    
    public TaskType()
    {
        CreatedAt=DateTime.Now;
    }
    
    
}
