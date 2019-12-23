using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Helios2._0.Startup))]
namespace Helios2._0
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
