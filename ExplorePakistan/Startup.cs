using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExplorePakistan.Startup))]
namespace ExplorePakistan
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
