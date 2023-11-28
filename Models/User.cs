namespace IssueReport.Models;

public class User
{
    public int UserId { get; set; }
    public string? Firstname { get; set; }

    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? Password { get; set; } 
    
    public int UserRoleId { get; set; }
    public UserRole? UserRole { get; set; }
    public ICollection<BugIssue>? BugIssues { get; set; }
    public ICollection<Recommendations>? Recommendations { get; set; }
}