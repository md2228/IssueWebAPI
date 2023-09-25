using Microsoft.EntityFrameworkCore;
using UncreativeProjectName1.Models;

namespace UncreativeProjectName1.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) 
            : base(options)
        {

        }

        public DbSet<Issue> Issues { get; set; }
    }
}
