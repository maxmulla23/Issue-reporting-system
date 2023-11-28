namespace IssueReport.Models;

public class Recommendations
{
    public int RecommendationId { get; set; }
    public string? RecTitle { get; set; }
    public string? RecDescription { get; set; }
    public DateTime CreationDate { get; set; }

    public int UserId { get; set; }
    public User? User{ get; set; }

}