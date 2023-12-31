namespace IssueReport.Models;

public class BugIssue
{
    public int BugIssueId { get; set; }
    public string? IssueTitle { get; set; }
    public string? IssueDescription { get; set; }
    
    public int UserId { get; set; }
    public User? User { get; set; }
}