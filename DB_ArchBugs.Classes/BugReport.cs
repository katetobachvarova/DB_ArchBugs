using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_ArchBugs.Classes
{
    public class BugReport
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public string Description { get; set; }
        public BugReportSeverityType SeverityType { get; set; }
        public Location Location { get; set; }
        public int LocationId { get; set; }
        public User User { get; set; }
        public int UserId { get; set; }


    }
}
