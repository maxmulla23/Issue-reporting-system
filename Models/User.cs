namespace IssueReport.Models;

public class User
{
    public int Id { get; set; }
    public string? Firstname { get; set; }

    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? password { get; set; } 
    public string? UserType { get; set; }
}