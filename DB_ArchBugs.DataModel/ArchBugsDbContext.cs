using DB_ArchBugs.Classes;
using System.Data.Entity;

namespace DB_ArchBugs.DataModel
{
    public class ArchBugsDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<BugReport> BugReports { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
