using DB_ArchBugs.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;




namespace DB_ArchBugs.DataModel
{
    public class DisconnectedRepository
    {
        public List<BugReport> GetArchBugsWithUsersAndLocations()
        {
            using (var context = new ArchBugsDbContext())
            {
                return context.BugReports.AsNoTracking().Include(b => b.Location).Include(b => b.User).ToList();
            }
        }

        public BugReport GetBugReportById(int id)
        {
            using (var context = new ArchBugsDbContext())
            {
                //return context.BugReports.Find(id);
                 return context.BugReports.AsNoTracking().Include(b => b.Location).Include(b => b.User).SingleOrDefault(n => n.Id == id);
            }
        }
    }
}
