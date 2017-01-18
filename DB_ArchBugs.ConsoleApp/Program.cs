using DB_ArchBugs.DataModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_ArchBugs.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new NullDatabaseInitializer<ArchBugsDbContext>());
    
            DataHelpers.NewDbWithSeed();
            Console.ReadKey();
        }
    }
}
