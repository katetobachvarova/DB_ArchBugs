using DB_ArchBugs.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_ArchBugs.DataModel
{
    public class DataHelpers
    {
        public static void NewDbWithSeed()
        {

            Database.SetInitializer(new DropCreateDatabaseAlways<ArchBugsDbContext>());
            using (var context = new ArchBugsDbContext())
            {
                if (context.BugReports.Any())
                {
                    return;
                }
                Location loc1 = new Location(123.6, 345.6, "location1");
                Location loc2 = new Location(123.6, 345.6, "location2");
                context.Locations.AddRange(new List<Location> { loc1, loc2 });

                User user1 = new User() { Email = "kat@abv.bg", Name = "Kat1" };
                User user2 = new User() { Email = "maria@abv.bg", Name = "maria" };
                context.Users.AddRange(new List<User> { user1, user2 });

                BugReport first = new BugReport() { Description="this is the first one", Name="first", User = user1, Location = loc1, SeverityType = BugReportSeverityType.Major};
                BugReport second = new BugReport() { Description = "this is the second one", Name = "second", User = user2, Location = loc2, SeverityType = BugReportSeverityType.Minor };
                context.BugReports.AddRange(new List<BugReport> { first, second });

                context.SaveChanges();
            }
        }
    }
}
