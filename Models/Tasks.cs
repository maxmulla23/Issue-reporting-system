namespace IssueReport.Models;

public class Tasks
{
    public int TaskId { get; set; }
    public string? TaskTitle { get; set; }
    public string? TaskDescription { get; set; }
    public DateTime Creationdate { get; set; }
    public DateTime Deadline { get; set; } 
}