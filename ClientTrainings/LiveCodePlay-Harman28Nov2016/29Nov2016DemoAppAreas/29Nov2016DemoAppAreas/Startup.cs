using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_29Nov2016DemoAppAreas.Startup))]
namespace _29Nov2016DemoAppAreas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
