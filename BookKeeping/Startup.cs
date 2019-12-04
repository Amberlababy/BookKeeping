using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BookKeeping.Startup))]
namespace BookKeeping
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
