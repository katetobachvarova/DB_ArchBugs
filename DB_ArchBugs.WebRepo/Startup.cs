using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DB_ArchBugs.WebRepo.Startup))]
namespace DB_ArchBugs.WebRepo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
