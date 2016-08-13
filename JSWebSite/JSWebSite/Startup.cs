using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JSWebSite.Startup))]
namespace JSWebSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
