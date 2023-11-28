using System;
using Microsoft.EntityFrameworkCore;
namespace IssueReport.Models;

public class IssueReportContext : DbContext
{
    public DbSet<User>? Users { get; set; }
    public DbSet<UserRole>? UserRoles { get; set; }
    public DbSet<Recommendations>? Recommendations { get; set; }
    public DbSet<BugIssue>? bugIssues { get; set; }
    public DbSet<Tasks>? Tasks { get; set; }
}
