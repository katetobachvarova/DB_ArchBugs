using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_ArchBugs.Classes
{
    public class Location
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public double X { get; set; }
        public double Y { get; set; }

        public Location(double x, double y, string description)
        {
            this.X = x;
            this.Y = y;
            this.Description = description;
        }

        public Location() 
            : this(0.0, 0.0, "Empty location")
        { }
    }
}
